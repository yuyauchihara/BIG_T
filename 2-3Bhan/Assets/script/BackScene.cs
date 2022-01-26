using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScene : MonoBehaviour
{

    public void BackTitle()
    {
        Time.timeScale = 1f;
        StartCoroutine(BackTitleScene());
    }

    IEnumerator BackTitleScene()
    {
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene("Title Scene");
    }
}
