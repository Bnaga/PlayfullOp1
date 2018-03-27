using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour {

    public GameObject cubePrefab;
    public int numObjects = 5;
	// Use this for initialization
	void Start ()
    {
        for(int i=0; i<numObjects; i++)
        {
            Instantiate(cubePrefab, new Vector3(i, i, 0), Quaternion.Euler(0, 45, 0));
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
