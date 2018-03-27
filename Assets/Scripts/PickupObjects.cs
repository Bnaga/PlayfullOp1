using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjects : MonoBehaviour {

    public GameObject cam;
    public float range = 5;
    private GameObject pickup;
    public Vector3 offset;
    public LayerMask layer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.F))
        {
            if (pickup == null)
            {
                RaycastHit hit;
                if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range, layer))
                {
                    pickup = hit.collider.gameObject;
                    pickup.GetComponent<Rigidbody>().isKinematic = true;
                }
            }
            else
            {
                TranspaOff();
                pickup.GetComponent<Rigidbody>().isKinematic = false;
                pickup = null;
            }
        }

        if(pickup != null)
        {
            pickup.transform.rotation = cam.transform.rotation;
            Vector3 targetPos = cam.transform.position + cam.transform.forward * offset.z + cam.transform.right * offset.x + cam.transform.up * offset.y;
            pickup.transform.position = targetPos;
            SetTransparent();
            
        }
	}

    void SetTransparent()
    {
        pickup.GetComponent<Renderer>().material.EnableKeyword("_ALPHABLEND_ON");
        Color c = pickup.GetComponent<Renderer>().material.color;
        c.a = 0f;
        pickup.GetComponent<Renderer>().material.color = c;
    }

    void TranspaOff()
    {
        pickup.GetComponent<Renderer>().material.EnableKeyword("_NORMALMAP");
        Color c = pickup.GetComponent<Renderer>().material.color;
        c.a = 1f;
        pickup.GetComponent<Renderer>().material.color = c;
    }
}
