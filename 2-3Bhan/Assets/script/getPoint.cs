using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getPoint : MonoBehaviour

{
    //public GameObject score_obj = null;
    public Text scoreText;

    private int MaxPoint = 1000;

    public static int cPoint;
    public static int tmp;//前の値
    public static bool clear;

    private int point1 = 20;
    private int point2 = 20;
    private int point3 = 20;
    private int point4 = 20;

    private float cTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        tmp = 0;

        clear = false;
        cTime = 0f;
        cPoint = 0;
        SetScore();
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

                    tmp = cPoint - point1;
                    tmp = cPoint - tmp;
                    cTime = 0;

                    
                }

                if (area.kyusoku2 == true)
                {
                    cPoint += point2;

                    tmp = cPoint - point2;
                    tmp = cPoint - tmp;


                    cTime = 0;

                    


                }
                 if (area.kyusoku3 == true)

                {
                    cPoint += point3;

                    tmp = cPoint - point3;
                    tmp = cPoint - tmp;

                    
                    cTime = 0;

                    
                }
                if (area.kyusoku4 == true)

                {
                    cPoint += point4;

                    tmp = cPoint - point4;
                    tmp = cPoint - tmp;

                    cTime = 0;

                    
                }

                if (cPoint >= MaxPoint)
                {
                    cPoint = MaxPoint;

                    //持てるポイントの数がMAXを超えたら強制的にMAXにする
                }

                Debug.Log("プラス" + tmp);

                SetScore();
               //Debug.Log(cPoint+"/最大1000");
               

            }


            if (cPoint >= MaxPoint)//debug用
            {
                clear = true;
                Debug.Log("クリア");
            }
        }

        
    }

    void SetScore()
    {
        scoreText.text = string.Format("{0}", cPoint);
    }

}
