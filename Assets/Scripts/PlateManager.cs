using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateManager : MonoBehaviour {

    public bool plate1 = false;
    public bool plate2 = false;

    public GameObject gate;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(plate1 && plate2)
        {
            gate.SetActive(true);
        }
	}
}
