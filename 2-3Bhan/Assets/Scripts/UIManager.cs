﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class UIManager : MonoBehaviour
{

    //３つのPanelを格納する変数
    //インスペクターウィンドウからゲームオブジェクトを設定する
    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject xrHubPanel;
    [SerializeField] GameObject unityPanel;


    // Start is called before the first frame update
    void Start()
    {
        //BackToMenuメソッドを呼び出す
        BackToMenu();
    }


    //MenuPanelでXR-HubButtonが押されたときの処理
    //XR-HubPanelをアクティブにする
    public void SelectXrHubDescription()
    {
        menuPanel.SetActive(false);
        xrHubPanel.SetActive(true);
    }


    //MenuPanelでUnityButtonが押されたときの処理
    //UnityPanelをアクティブにする
    public void SelectUnityDescription()
    {
        menuPanel.SetActive(false);
        unityPanel.SetActive(true);
    }


    //2つのDescriptionPanelでBackButtonが押されたときの処理
    //MenuPanelをアクティブにする
    public void BackToMenu()
    {
        menuPanel.SetActive(true);
        xrHubPanel.SetActive(false);
        unityPanel.SetActive(false);
    }
}