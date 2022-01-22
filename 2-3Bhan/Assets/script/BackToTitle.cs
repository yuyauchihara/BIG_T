using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackToTitle : MonoBehaviour
{
    public Button button;
    void Start()
    {
        button.GetComponent<Button>().Select();
    }

    void OnEnable()
    {
        button.GetComponent<Button>().Select();
        //Debug.Log("aaa");

    }
}
