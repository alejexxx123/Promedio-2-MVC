using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centro : MonoBehaviour {

    GameObject punto;
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("me estas tocando");

        }
    }
}
