using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateGate2 : MonoBehaviour {

    public PlateManager platemanager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Box")
        {
            platemanager.plate1 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Box")
        {
            platemanager.plate1 = false;
        }
    }
}
