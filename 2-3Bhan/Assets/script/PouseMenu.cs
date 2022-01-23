using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PouseMenu : MonoBehaviour
{
    [SerializeField] private GameObject Panel;
    private int backP = 0;

    void Start()
    {
        Panel.SetActive(false);

    }
    void Update()
    {

        // スタートボタンを押したらポーズメニューを開く、閉じる
        if (Input.GetKeyDown("joystick button 7") && backP == 0)
        {
            Pause();
            backP++;
            Time.timeScale = 0f;//時間停止
        }
        else if (Input.GetKeyDown("joystick button 7") && backP == 1)
        {
            Resume();
            backP--;
            Time.timeScale = 1f;//時間再稼働
        }
    }
    

    private void Pause()
    {
        Panel.SetActive(true);
    }

    private void Resume()
    {
        Panel.SetActive(false);
    }
}
