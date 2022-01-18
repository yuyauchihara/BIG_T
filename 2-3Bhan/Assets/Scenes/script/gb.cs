using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gb : MonoBehaviour
{

    public int MaxHP = 100;//最大
    public int HP=30;//いまのHP(仮）
    private float cTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (area.i == true)
        {
            cTime += Time.deltaTime;

            if (cTime >= 1.0f&&HP<MaxHP)
            {
                HP += 10;
                cTime = 0;
                Debug.Log(HP);
                
            }
        }
    }
}
