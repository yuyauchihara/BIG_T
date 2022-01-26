using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToRetry : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ClearCoroutine());
    }

    IEnumerator ClearCoroutine()
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("Retry");
    }
}
