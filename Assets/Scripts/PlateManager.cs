using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateManager : MonoBehaviour {

    public bool plate1 = false;
    public bool plate2 = false;
    public int currentPlates = 2;

    public GameObject gate;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(plate1)
        {
            currentPlates = 1;
        }
        if (plate2)
        {
            currentPlates = 1;
        }
        if (!plate1 && !plate2)
        {
            currentPlates = 2;
            gate.SetActive(false);
        }
        if (plate1 && plate2)
        {
            currentPlates = 0;
            gate.SetActive(true);
        }
	}
}
