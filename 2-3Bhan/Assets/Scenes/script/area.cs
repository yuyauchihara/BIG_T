using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class area : MonoBehaviour
{
     public static bool i = false;

    public static bool kyusoku1 = false;
    public static bool kyusoku2 = false;
    public static bool kyusoku3 = false;
    public static bool kyusoku4 = false;

    // Start is called before the first frame update
    void Start()
    {
        i = false;
        kyusoku1 = false;
        kyusoku2 = false;
        kyusoku3 = false;
        kyusoku4 = false;
    }

	// Update is called once per frame

	void OnTriggerStay(Collider other)//エリア内に接している間ずっと呼び出される
	{
		
        
		if (other.gameObject.CompareTag("Player"))
        { 
			//Debug.Log("内");
            i = true;

            if (this.gameObject.name == "kyusoku1")
            {
                kyusoku1 = true;
                //Debug.Log("1");
            }

            else if (this.gameObject.name == "kyusoku2")
            {
                kyusoku2 = true;
                //Debug.Log("2");

            }
            else if (gameObject.name == "kyusoku3")
           
            {
                kyusoku3 = true;
                //Debug.Log("3");

            }else if (gameObject.name == "kyusoku4")  
            {
                kyusoku4 = true;
                //Debug.Log("4");

            }

		}
	}

    private void OnTriggerExit(Collider other)
    {
        i = false;
        kyusoku1 = false;
        kyusoku2 = false;
        kyusoku3 = false;
        kyusoku4 = false;
    }
}

