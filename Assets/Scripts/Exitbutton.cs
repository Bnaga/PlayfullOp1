using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exitbutton : MonoBehaviour {


    public Material hoverExit;
    public Material pressExit;
    public Material stoneHover;
    public Material stonePress;
    public GameObject hoverLight;
    public GameObject pressLight;
    public GameObject stone1;
    public GameObject stone2;
    public GameObject stone3;
    public GameObject stone4;
    Material stoneMaterial;
    Material standard;
    // Use this for initialization
    void Start ()
    {
        standard = GetComponent<Renderer>().material;
        stoneMaterial = stone1.GetComponent<Renderer>().material;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseOver()
    {
        if (!Input.GetKeyDown(KeyCode.Mouse0))
        {
            GetComponent<Renderer>().material = hoverExit;
            stone1.GetComponent<Renderer>().material = stoneHover;
            stone2.GetComponent<Renderer>().material = stoneHover;
            stone3.GetComponent<Renderer>().material = stoneHover;
            stone4.GetComponent<Renderer>().material = stoneHover;
            hoverLight.SetActive(true);
            pressLight.SetActive(false);
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            GetComponent<Renderer>().material = pressExit;
            stone1.GetComponent<Renderer>().material = stonePress;
            stone2.GetComponent<Renderer>().material = stonePress;
            stone3.GetComponent<Renderer>().material = stonePress;
            stone4.GetComponent<Renderer>().material = stonePress;
            hoverLight.SetActive(false);
            pressLight.SetActive(true);
            StartCoroutine("ExitGame");
        }
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material = standard;
        stone1.GetComponent<Renderer>().material = standard;
        stone2.GetComponent<Renderer>().material = standard;
        stone3.GetComponent<Renderer>().material = standard;
        stone4.GetComponent<Renderer>().material = standard;
        hoverLight.SetActive(false);
        pressLight.SetActive(false);
    }

    IEnumerator ExitGame()
    {
        yield return new WaitForSeconds(0);
        Application.Quit();
    }
}
