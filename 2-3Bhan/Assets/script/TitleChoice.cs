using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleChoice : MonoBehaviour
{
    public Button button;
    public Button button2;
    public Button button3;
    //public Button FirstSelectButton;
    void Start()
    {
        //button2.GetComponent<Button>().Select();

        ////ボタンが選択された状態になる
        //button.GetComponent<Button>().Select();
        //FirstSelectButton.Select();
    }
    void OnEnable()
    {
        button3.GetComponent<Button>().Select();

        button2.GetComponent<Button>().Select();

        ////ボタンが選択された状態になる
        button.GetComponent<Button>().Select();

    }
}
