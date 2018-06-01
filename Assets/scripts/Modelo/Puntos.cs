using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntos : MonoBehaviour {

    public float contpuntos;
    centro Center;

    // Use this for initialization
    void Start() {
        transform.Rotate(0, 1, 0);
        contpuntos = 0;

	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            Debug.Log("obtienes un punto");
            contpuntos += 1;
            this.gameObject.SetActive(false);
            Debug.Log(contpuntos);
            if (contpuntos == 4)
            {
                Debug.Log("tienes todos");
                Center.gameObject.SetActive(true);
            }
        }
    }
 }
    

