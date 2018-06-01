using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centro : MonoBehaviour {

    public GameObject puntos;
    
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        puntos.SetActive(true);
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("me estas tocando");
            this.gameObject.SetActive(false);
        }
        
    }
}
