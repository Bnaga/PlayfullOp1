using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateGate : MonoBehaviour {

    public GameObject gate;
	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Box")
        {
            gate.SetActive(true);
        }

        if (other.tag == "Player")
        {
            Debug.Log("player");
            gate.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Box")
        {
            gate.SetActive(false);
        }

        if (other.tag == "Player")
        {
            gate.SetActive(false);
        }
    }
}
