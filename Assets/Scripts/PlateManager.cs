using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateManager : MonoBehaviour {

    public PressurePlate[] pressurePlates;
    public float plates = 0;
    public GameObject gate;

    public GameObject uix;
    private Material mat2;
    public Material mat1;
    public Material mat0;
    // Use this for initialization
    void Start ()
    {
        plates = pressurePlates.Length;
        mat2 = uix.GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Mathf.Floor(plates);
        if (plates >0)
        {
            gate.SetActive(false);
            if (plates == 2)
            {
                uix.GetComponent<Renderer>().material = mat2;
            }
            if (plates == 1)
            {
                uix.GetComponent<Renderer>().material = mat1;
            }

        }
        if (plates == 0)
        {
            gate.SetActive(true);
            uix.GetComponent<Renderer>().material = mat0;
        }


	}
}
