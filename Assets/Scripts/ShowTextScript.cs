using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextScript : MonoBehaviour {

    bool collided = false;
    public bool isPickedUp = false;
    string uiText = "Press F to pick up";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void OnGUI()
    {
        if(collided && !isPickedUp)
        {
            Rect rect = new Rect(140, Screen.height /2, Screen.width - 300, 120);
            GUI.Box(rect, uiText);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            collided = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            collided = false;
        }
    }
}
