using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//#if UNITY_EDITOR
using UnityEditor;
public class PouseEnd : MonoBehaviour
{
    public void GameEnd()
    {
        Time.timeScale = 1f;
        StartCoroutine(GameEndScene());
    }

    IEnumerator GameEndScene()
    {
        yield return new WaitForSeconds(0.8f);
        Application.Quit();
    }
}
//#endif