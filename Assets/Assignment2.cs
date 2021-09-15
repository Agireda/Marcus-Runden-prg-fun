using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignment2 : ProcessingLite.GP21
{
    float spaceBetweenLines = 1;

    void Start()
    {

    }

    void Update()
    {
        //Clear background
        Background(0, 0, 0);

        //Draw our art, or in this case a rectangle
        //Rect(1, 1, 3, 3);

        Stroke(255, 255, 255);
        StrokeWeight(1);

        //Draw our scan lines
        for (int i = 0; i < Height / spaceBetweenLines; i++)
        {
            //Increase y-cord each time loop run
            float y = i * spaceBetweenLines;

            //Draw a line from left side of screen to the right
            Line(0, y, Width, y);
        }
    }
}
