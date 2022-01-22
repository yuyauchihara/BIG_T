using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PouseChoice : MonoBehaviour
{
    public Button button;
    public Button button2;
    public RectTransform a;

    void OnEnable()
    {
        button2.GetComponent<Button>().Select();
        //ボタンが選択された状態になる
        button.GetComponent<Button>().Select();

    }

}
