using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryCh : MonoBehaviour
{

    //メインゲームシーンへ切り替え
    public void MainScene()
    {
        SceneManager.LoadScene("SampleScene");
        //Debug.Log("Main");
    }

    //タイトルシーンへ切り替え
    public void TitleScene()
    {
        StartCoroutine(TitleC());

       
    }

    //ゲーム終了
    public void GameEnd()
    {
        StartCoroutine(GameEndScene());
    }

    IEnumerator TitleC()
    {
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene("Title Scene");
        //Debug.Log("title");
    }

    IEnumerator GameEndScene()
    {
        yield return new WaitForSeconds(0.8f);
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

}