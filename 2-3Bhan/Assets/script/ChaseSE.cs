using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseSE : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    public bool volumeUp;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0.1f;
        volumeUp = false;
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
            StartCoroutine("VolumeUp");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine("VolumeDown");
        }
    }

    IEnumerator VolumeUp()
    {
        if (!volumeUp)
            while (audioSource.volume < 0.1)
            {
                audioSource.volume += 0.01f;
                yield return new WaitForSeconds(0.1f);
            }
        volumeUp = true;
    }

    IEnumerator VolumeDown()
    {
        while (audioSource.volume > 0)
        {
            audioSource.volume -= 0.001f;
            yield return new WaitForSeconds(0.1f);
            if(audioSource.volume == 0)
            {
                audioSource.Stop();
            }
        }
        volumeUp = false;
    }

}
