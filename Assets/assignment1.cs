using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignment1 : ProcessingLite.GP21
{

    public float x;
    public float y;
    public float diameter = 2f;

    // Start is called before the first frame update
    void Start()
    {

        
        //  Line(4, 7, 4, 3);
        //  Line(4, 5, 6, 5);
        //  Line(6, 7, 6, 3);

        //  Line(8, 5.5f, 8, 3);
        //  Line(8, 7, 8, 6.8f);


    }

    // Update is called once per frame
    void Update()
    {

        //   Circle(circlePosition.x, circlePosition.y, diameter);
        //   LetterR();

        //  void LetterR(float x = 0, float y = 0);
        //      Stroke(0, 0, 0);
        
        //      Line(x + 3, y + 3, x + 3, y + 12);
        //      Line(x + 3, y + 12, x + 6, y + 9);
        //      Line(x + 6, y + 9, x + 3, y + 6);
        //      Line(x + 3, y + 6, x + 6, y + 4);

        
        //fill(0, 0, 139); ej p� circle tills vidare
        Background(255, 140, 0);
        StrokeWeight(2);

        Fill(0, 0, 255);
        Rect(12, 12, 13.5f, 13.5f);
        Fill(255, 0, 0);
        Rect(1, 1, 2.5f, 2.5f);
        Fill(0, 255, 0);
        Rect(26, 12, 27.5f, 13.5f);

        Fill(0, 0, 139);
        Stroke(0, 0, 139);
        Circle(x + 27.5f, y + 1.5f, diameter);

        Stroke(0, 0, 0);
        Fill(153, 50, 204);
        Circle(x + 1.5f, y + 13.5f, diameter);


         Line(3, 3, 3, 12);
         Line(3, 12, 6, 9);
         Line(6, 9, 3, 6);
         Line(3, 6, 6, 4);

         Line(8, 3, 8, 10);
         Line(8, 3, 11, 4);
         Line(11, 4, 11, 10);
         Line(8, 4, 11, 5);

         Line(13, 3, 13, 10);
         Line(13, 10, 15, 7);
         Line(13, 7, 15, 3);
         Line(15, 3, 15, 10);

         Line(17, 3, 17, 10);
         Line(17, 10, 19, 6.5f);
         Line(19, 6.5f, 17, 3);

         Line(20, 9, 22, 10);
         Line(20, 9, 22, 7);
         Line(22, 7, 20, 5);
         Line(20, 5, 22, 3);
         Line(21, 11, 22, 12);

         Line(24, 3, 24, 10);
         Line(24, 10, 26, 7);
         Line(24, 7, 26, 3);
         Line(26, 3, 26, 10);

    }
}
