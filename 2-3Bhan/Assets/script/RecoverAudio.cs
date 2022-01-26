using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoverAudio : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    int SEflag = 1;
    float SEtime = 0;
    float SEspan = 180;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        SEtime++;
        //Debug.Log(SEtime);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            
            if (SEflag == 1)
            {
                //Debug.Log("音が鳴った");
                //音(sound1)を鳴らす
                audioSource.PlayOneShot(sound1);

                SEflag = 0;
            }

            if (SEflag == 0)
            {
                //Debug.Log("flagを変えようとしている");
                if (SEtime > SEspan)
                {
                    //Debug.Log("flagを変えた");
                    SEflag = 1;
                    SEtime = 0;
                }
            }
        }
    }
}
