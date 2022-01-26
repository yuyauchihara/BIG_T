using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateSE : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    int Gflag = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (getPoint.cPoint == 1000)
        {
            if (Gflag == 0)
            {
                //音(sound1)を鳴らす
                audioSource.PlayOneShot(sound1);
                Gflag = 1;
            }

        }
    }
}
