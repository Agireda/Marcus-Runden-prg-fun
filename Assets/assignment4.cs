using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignment4 : ProcessingLite.GP21
{
    Vector2 position;
    Vector2 position2;
    float diameter = 1;
    float speed = 5f;
    Vector2 velocity;
    Vector2 acceleration;

    // Start is called before the first frame update
    void Start()
    {
        position = new Vector2(Width / 2, Height / 2);
        position2 = new Vector2(Width / 2, Height / 2);

    }

    // Update is called once per frame
    void Update()
    {
        Background(50, 166, 240);

        //Input from player
        float x = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float y = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        //Circle 1, with acceleration
        acceleration = new Vector2(x, y);
        velocity += acceleration * Time.deltaTime;
        
        if (velocity.magnitude > 0.01f)
        {
            velocity = velocity.normalized * 0.01f;
        }
        else if (acceleration == Vector2.zero)
        {
            velocity *= 0.99f;
        }

        position += velocity;
        Circle(position.x, position.y, diameter);

        //Circle 2, no acceleration
        position2 += new Vector2(x, y);
        //Circle(position2.x, position2.y, diameter);
    }
}
