using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject FPSController;
    public Canvas GameOverText;
    FirstPersonController controller;

    void Start()
    {
        controller = FPSController.GetComponent<FirstPersonController>();
        GameOverText.enabled = false;
        Time.timeScale = 1f;
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
            controller.enabled = false;
            Time.timeScale = 0f;
        }
    }
}