using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Canvas GameOverText;
    FirstPersonController controller;
    
    void Start()
    {
        GameOverText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("触れた");
            GameOverText.enabled = true;
            Time.timeScale = 0;
            controller.enabled = false;
        }
    }
}