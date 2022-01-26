using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Countdown : MonoBehaviour
{
    [SerializeField]
    private Text _CountdownText;

    //[SerializeField]
    //private Image _imageMask;

    void Start()
    {
        _CountdownText.text = "";
        StartCoroutine(CountdownCoroutine());
    }

    IEnumerator CountdownCoroutine()
    {
        _CountdownText.gameObject.SetActive(true);

        _CountdownText.text = "5";
        yield return new WaitForSeconds(1.0f);

        _CountdownText.text = "4";
        yield return new WaitForSeconds(1.0f);

        _CountdownText.text = "3";
        yield return new WaitForSeconds(1.0f);

        _CountdownText.text = "2";
        yield return new WaitForSeconds(1.0f);

        _CountdownText.text = "1";
        yield return new WaitForSeconds(1.0f);

        _CountdownText.text = "0";
        _CountdownText.gameObject.SetActive(false);
    }
}
