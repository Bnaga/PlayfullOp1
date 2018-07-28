using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour

{
    public PlateManager plateManager;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Box")
        {
            plateManager.plates -= .5f;
        }

        if (other.tag == "Box2")
        {
            plateManager.plates -= 1f;
        }

        if (other.tag == "Player")
        {
            plateManager.plates -= 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Box")
        {
            plateManager.plates += .5f;
        }

        if (other.tag == "Box2")
        {
            plateManager.plates += 1f;
        }

        if (other.tag == "Player")
        {
            plateManager.plates += 1;
        }
    }
}
