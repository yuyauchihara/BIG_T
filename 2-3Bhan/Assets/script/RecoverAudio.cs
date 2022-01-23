using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoverAudio : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    int SEflag = 1;
    float SEtime = 0;
    float SEspan = 400;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        SEtime++;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            
            if (SEflag == 1)
            {
                //音(sound1)を鳴らす
                audioSource.PlayOneShot(sound1);

                SEflag = 0;
            }

            if (SEflag == 0)
            {
                if (SEtime > SEspan)
                {
                    SEflag = 1;
                    SEtime = 0;
                }
            }
        }
    }
}
