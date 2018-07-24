using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateGate3 : MonoBehaviour {

    public PlateManager platemanager;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Box2")
        {
            platemanager.plate2 = true;
        }

        if (other.tag == "Box")
        {
            platemanager.plate2 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Box2")
        {
            platemanager.plate2 = false;
        }

        if (other.tag == "Box")
        {
            platemanager.plate2 = false;
        }
    }
}
