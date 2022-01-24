using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gate1 : MonoBehaviour
{
    int score = 0;

    private void Update()
    {

        if (getPoint.cPoint >= 1000)
        {
            Destroy(gameObject);

        }


    }
}
