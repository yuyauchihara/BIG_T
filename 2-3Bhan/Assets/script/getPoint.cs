using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getPoint : MonoBehaviour

{


   private int MaxPoint = 1000;

    public static int cPoint;

    private int point1 = 10;
    private int point2 = 100;
    private int point3 = 300;
    private int point4 = 500;

    private float cTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        cTime = 0f;
        cPoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (area.i == true) {

            cTime += Time.deltaTime;

            if (cPoint<MaxPoint &&cTime>=1.0f)
            {
                if (area.kyusoku1 == true)
                {
                    cPoint += point1;
                    cTime = 0;
                }

                if (area.kyusoku2 == true)
                {
                    cPoint += point2;
                    cTime = 0;

                }
                 if (area.kyusoku3 == true)

                {
                    cPoint += point3;
                    cTime = 0;

                }
                if (area.kyusoku4 == true)

                {
                    cPoint += point4;
                    cTime = 0;

                }
                Debug.Log(cPoint+"/最大1000");
            }  
        }
    }
}
