using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punto : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 1, 0);
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("obtienes un punto");

        }
    }
}
