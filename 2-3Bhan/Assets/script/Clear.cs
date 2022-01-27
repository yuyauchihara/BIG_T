using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    [SerializeField]
    private Text _Cleartext;

    [SerializeField]
    private Image _imageMask;

    [SerializeField]
    private Text _HPtext;

    [SerializeField]
    private Slider _HPBar;

    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        _Cleartext.text = "";
        _imageMask.gameObject.SetActive(false);
        _Cleartext.gameObject.SetActive(false);

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            StartCoroutine(ClearCoroutine());

            GameObject.Find("yuka").GetComponent<PouseMenu>().enabled = false;

            //音(sound1)を鳴らす
            audioSource.PlayOneShot(sound1);
        }
    }
    IEnumerator ClearCoroutine()
    {
        _HPBar.gameObject.SetActive(false);
        _HPtext.gameObject.SetActive(false);

        _imageMask.gameObject.SetActive(true);
        _Cleartext.gameObject.SetActive(true);
        _Cleartext.text = "GameClear";
        yield return new WaitForSeconds(5.0f);
        _Cleartext.text = "";
        SceneManager.LoadScene("Retry");
        //_imageMask.gameObject.SetActive(false);
        //_Cleartext.gameObject.SetActive(false);
    }
}
