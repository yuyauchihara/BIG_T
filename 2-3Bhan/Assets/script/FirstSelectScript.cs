﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstSelectScript : MonoBehaviour
{
    public Button FirstSelectButton;
    void Start()
    {
        FirstSelectButton.Select();
    }
}