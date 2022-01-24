using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointplus : MonoBehaviour
{
    public Text pointText;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (area.i == true)
        {
            if (getPoint.tmp != 0 && getPoint.clear == false)
            {
                anim.SetTrigger("AnimationSendEvent");
                pointText.text = string.Format("+{0}", getPoint.tmp);
            }


        }
        else
        {
            getPoint.tmp = 0;
            pointText.text = string.Format("", getPoint.tmp);
        }
    }
}
