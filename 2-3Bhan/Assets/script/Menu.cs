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

        StartCoroutine(TilteDelay1());
 
    }


    //TitlePanelでRuleButtonが押されたときの処理
    //RulePanelをアクティブにする
    public void SelectUnityDescription()
    {
        StartCoroutine(TilteDelay2());

        
    }


    //2つの操作説明、ルールPanelでBackButtonが押されたときの処理
    //TitlePanelをアクティブにする
    public void BackToMenu()
    {
        StartCoroutine(TilteDelay3());

        
    }


    //メインシーンへ切り替え
    public void Scene()
    {
        StartCoroutine(TilteDelay4());
        //SceneManager.LoadScene("シーン名");
    }


    IEnumerator TilteDelay1()
    {
        yield return new WaitForSeconds(0.8f);

        TitlePanel.SetActive(false);
        OperationPanel.SetActive(true);
    }

    IEnumerator TilteDelay2()
    {
        yield return new WaitForSeconds(0.8f);

        TitlePanel.SetActive(false);
        RulePanel.SetActive(true);
    }

    IEnumerator TilteDelay3()
    {
        yield return new WaitForSeconds(0.8f);

        TitlePanel.SetActive(true);
        OperationPanel.SetActive(false);
        RulePanel.SetActive(false);
    }

    IEnumerator TilteDelay4()
    {
        yield return new WaitForSeconds(0.8f);


    }
}