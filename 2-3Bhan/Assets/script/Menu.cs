using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu: MonoBehaviour
{
    //３つのPanelを格納する変数
    //インスペクターウィンドウからゲームオブジェクトを設定する
    [SerializeField] GameObject TitlePanel;
    [SerializeField] GameObject OperationPanel;
    [SerializeField] GameObject RulePanel;


    // Start is called before the first frame update
    void Start()
    {
        //BackToMenuメソッドを呼び出す
        BackToMenu();
    }


    //TitlePanelでOperationButtonが押されたときの処理
    //OperationPanelをアクティブにする
    public void SelectXrHubDescription()
    {
        TitlePanel.SetActive(false);

        OperationPanel.SetActive(true);
    }


    //TitlePanelでRuleButtonが押されたときの処理
    //RulePanelをアクティブにする
    public void SelectUnityDescription()
    {
        TitlePanel.SetActive(false);
        RulePanel.SetActive(true);
    }


    //2つの操作説明、ルールPanelでBackButtonが押されたときの処理
    //TitlePanelをアクティブにする
    public void BackToMenu()
    {
        TitlePanel.SetActive(true);
        OperationPanel.SetActive(false);
        RulePanel.SetActive(false);
    }


    //メインシーンへ切り替え
    public void Scene()
    {
        SceneManager.LoadScene("SampleScene");
    }

}