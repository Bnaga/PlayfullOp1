using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextScript : MonoBehaviour {

    public bool collided = false;
    public bool hasCollided = false;
    public bool isPickedUp = false;
    public bool hadCollided = false;
    //string uiText = "Press F to pick up";
    public ShowText text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            collided = true;
            hadCollided = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            collided = false;
            hadCollided = true;
        }
    }
}
