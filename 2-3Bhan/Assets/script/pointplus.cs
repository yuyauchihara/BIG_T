using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointplus : MonoBehaviour
{
    public Text pointText;
    public Animator anim;

 
    float cTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        cTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {

        if (area.i == true)
        {
            cTime += Time.deltaTime;

            if (getPoint.tmp != 0 && getPoint.clear == false)
            {
               

                anim.SetFloat("Speed", cTime);
                anim.SetTrigger("AnimationSendEvent");
                pointText.text = string.Format("+{0}", getPoint.tmp);
                cTime = 0f;
               
            }
            

        }
        else
        {
            getPoint.tmp = 0;
            pointText.text = string.Format("", getPoint.tmp);
        }
    }
}
