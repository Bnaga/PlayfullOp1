using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxRespawn2 : MonoBehaviour
{

    public GameObject box1;
    public GameObject boxSpawn1;

    public GameObject box2;
    public GameObject boxSpawn2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Box")
        {
            Destroy(collision.collider.gameObject);
            Instantiate(box1, boxSpawn1.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }

        if (collision.collider.tag == "Box2")
        {
            Destroy(collision.collider.gameObject);
            Instantiate(box2, boxSpawn2.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }
    }
}
