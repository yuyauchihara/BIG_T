using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPBar : MonoBehaviour
{
    //最大HPと現在のHP。
  

    [SerializeField] public static int maxHp = 3000;
    [SerializeField] public int beat = 50;//回復量

    public static int currentHp;//現在のHP
    public  float cTime = 0f;//時間
   

    //Sliderを入れる
    public  Slider slider;

    void Start()
    {
        cTime = 0f;
        //Sliderを満タンにする。
        slider.value = 1;
        //現在のHPを最大HPと同じに。
        currentHp = maxHp;
       // Debug.Log("Start currentHp : " + currentHp);
    }

    //ColliderオブジェクトのIsTriggerにチェック入れること。
    private void Update()
    {
        float z = Input.GetAxis("Horizontal");
        float x = Input.GetAxis("Vertical");
        //Enemyタグのオブジェクトに触れると発動
        if (Input.GetKey("joystick button 4") && z != 0 || Input.GetKey("joystick button 4") && x != 0)
        {
            //ダメージは1～100の中でランダムに決める。
            int damage = 1;

            //現在のHPからダメージを引く
            if (currentHp > 0)
            {
                currentHp = currentHp - damage;
            }
            else
            {
                currentHp = 0;
                //FirstPersonController.m_IsWalking = false;
            }

            //Debug.Log("After currentHp : " + currentHp);

            //最大HPにおける現在のHPをSliderに反映。
            //int同士の割り算は小数点以下は0になるので、
            //(float)をつけてfloatの変数として振舞わせる。
            slider.value = (float)currentHp / (float)maxHp;

           
            //Debug.Log("slider.value : " + slider.value);
        }

        if (area.i == true)
        {
           cTime += Time.deltaTime;

            if (cTime >= 1.0f &&currentHp <maxHp)
            {
                currentHp += beat;
                cTime = 0;

                slider.value = (float)currentHp / (float)maxHp;

                //Debug.Log(currentHp);

            }
        }
    }
}