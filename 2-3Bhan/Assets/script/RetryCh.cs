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
        SceneManager.LoadScene("Title Scene");
        //Debug.Log("title");
    }

    //ゲーム終了
    public void GameEnd()
    {
        StartCoroutine(GameEndScene());
    }

    IEnumerator GameEndScene()
    {
        yield return new WaitForSeconds(0f);
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

}