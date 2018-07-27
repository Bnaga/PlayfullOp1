using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour {

    public bool showText = false;
    public int texts = 0;
    public GameObject text;
    public ShowTextScript[] cubes;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        for(int i = 0; i< cubes.Length; i++)
        {
            if(cubes[i].collided)
            {
                cubes[i].collided = false;
                texts += 1;
            }
            if(cubes[i].hadCollided)
            {
                cubes[i].hadCollided = false;
                texts -= 1;
            }
            if(texts >= 1)
            {
                texts = 1;
            }
            if (texts <= -1)
            {
                texts = 0;
            }
        }

        if(texts > 0)
        {
            showText = true;
        }
        if(texts <= 0)
        {
            showText = false;
        }

		if(showText)
        {
            text.SetActive(true);
        }
        else if(!showText)
        {
            text.SetActive(false);
        }
	}
}
