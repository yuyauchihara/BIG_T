using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalUI : MonoBehaviour
{
    [SerializeField]
    private Text Goaltext;

    [SerializeField]
    private Image Goalimage;

    int Gflag = 0;

    // Start is called before the first frame update
    void Start()
    {
        Goalimage.gameObject.SetActive(false);
        Goaltext.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (getPoint.cPoint == 1000)
        {
            if (Gflag == 0)
            {
                StartCoroutine(Goal());
            }
            
        }
    }

    IEnumerator Goal()
    {
        Gflag = 1;
        Goalimage.gameObject.SetActive(true);
        Goaltext.gameObject.SetActive(true);

        Goaltext.text = "ゴールが開いた!!!";
        yield return new WaitForSecondsRealtime(2.0f);
        Goaltext.text = "";
        Goalimage.gameObject.SetActive(false);
    }
}
