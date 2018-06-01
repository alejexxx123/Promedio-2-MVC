using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	
	
	// Update is called once per frame
	void FixedUpdate () {
        movPJ();
	}

    void movPJ()
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");

        transform.Rotate(0, 0, -x);
        transform.Translate(0, z, 0);
    }
}
