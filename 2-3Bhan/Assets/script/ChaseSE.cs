using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseSE : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && !audioSource.isPlaying)
        {
            //音(sound1)を鳴らす
            audioSource.PlayOneShot(sound1);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        audioSource.Stop();
    }
}
