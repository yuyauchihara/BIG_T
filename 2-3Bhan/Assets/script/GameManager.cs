using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Cameras;

public class GameManager : MonoBehaviour
{
	public void Retry()
    {
        Time.timeScale = 1f;//時間再稼働
        StartCoroutine(RetryScene());
    }
    public void Retry2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator RetryScene()
    {
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
