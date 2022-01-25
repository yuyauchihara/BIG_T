using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{
    public Canvas GameOverText;
    GameManager gameManager;
    FirstPersonController controller;
    // Use this for initialization
    void Start()
    {
        GameOverText.enabled = false;
        controller.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("触れた");
            GameOverText.enabled = true;
            controller.enabled = false;
        }
    }
}
