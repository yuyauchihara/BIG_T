using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class area : MonoBehaviour
{
    public static int cnt=0;
    public static bool i = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	// Update is called once per frame

	void OnTriggerStay(Collider other)//エリア内に接している間ずっと呼び出される
	{
		
		if (other.gameObject.CompareTag("Player"))
        { 
			Debug.Log("内");
            i = true;
		}
	}

    private void OnTriggerExit(Collider other)
    {
        i = false;
    }
}

