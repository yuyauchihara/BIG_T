﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleChoice : MonoBehaviour
{
    public Button button;
    public Button button2;
    public Button button3;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void OnEnable()
    {
        //button2.GetComponent<Button>().Select();

        //ボタンが選択された状態になる
        button.GetComponent<Button>().Select();
    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown("joystick button 10"))
    //    {
    //        a.position += new Vector3(1f + 1, 0, 0);
    //    }
    //}
}
