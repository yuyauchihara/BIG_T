using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Clear : MonoBehaviour
{
    [SerializeField]
    private Text _Cleartext;

    [SerializeField]
    private Image _imageMask;

    void Start()
    {
        _Cleartext.text = "";
        _imageMask.gameObject.SetActive(false);
        _Cleartext.gameObject.SetActive(false);

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            StartCoroutine(ClearCoroutine());
        }
    }
    IEnumerator ClearCoroutine()
    {
        _imageMask.gameObject.SetActive(true);
        _Cleartext.gameObject.SetActive(true);
        _Cleartext.text = "GameClear";
        yield return new WaitForSeconds(5.0f);
        _Cleartext.text = "";
        _imageMask.gameObject.SetActive(false);
        _Cleartext.gameObject.SetActive(false);
    }

}
