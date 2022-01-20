using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Retry()
    {
        Time.timeScale = 1f;//時間再稼働
        StartCoroutine(RetryScene());
    }

    IEnumerator RetryScene()
    {
        yield return new WaitForSeconds(0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
