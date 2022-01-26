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

    IEnumerator RetryScene()
    {
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
