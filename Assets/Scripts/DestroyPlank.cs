using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlank : MonoBehaviour {

    public GameObject plank;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            Destroy(plank);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(plank);
        }
    }
}
