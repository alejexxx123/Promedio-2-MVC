using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumapuntos : MonoBehaviour {
    public float contpuntos;
    public centro Center;
    public GameObject puntos;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "punto")
        {

            
            contpuntos += 1;
            
            Debug.Log(contpuntos);
            if (contpuntos == 3)
            {
                Debug.Log("tienes todos");
                Center.gameObject.SetActive(true);
                puntos.SetActive(false);
            }
        }
    }
}
