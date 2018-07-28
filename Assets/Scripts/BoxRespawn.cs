using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxRespawn : MonoBehaviour {

    public GameObject box;
    public GameObject boxSpawn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Box")
        {
            Destroy(collision.collider.gameObject);
            Instantiate(box, boxSpawn.transform.position+new Vector3(0,1,0), Quaternion.identity);
        }
    }
}
