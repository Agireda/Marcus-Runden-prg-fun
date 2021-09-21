using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignment2 : ProcessingLite.GP21
{

    //float spaceBetweenLines = 0.2f;

    int numberOfLines = 20;

    void Start()
    {
    }

    void Update()
    {
 
        Background(50, 166, 240);



        for (int i = 0; i <= numberOfLines; i++)
        {

            float y1 = Height - i * Height / numberOfLines;
            float x2 = i * Width / numberOfLines;
           

            if (i % 3 == 0)
            {

                Stroke(220, 20, 60);

            }
            else
            {
                Stroke(0, 0, 255);
            }


            Line(0, y1, x2, 0);
        }
    }
}
