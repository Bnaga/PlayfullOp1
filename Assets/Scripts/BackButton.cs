using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : ButtonScript {

    public PauseMenu pause;

    Material stoneMaterial;
    Material standard;

    void Start()
    {
        standard = GetComponent<Renderer>().material;
        stoneMaterial = stone1.GetComponent<Renderer>().material;
    }

    private void OnMouseOver()
    {
        if (!Input.GetKeyDown(KeyCode.Mouse0))
        {
            GetComponent<Renderer>().material = hover;
            stone1.GetComponent<Renderer>().material = stoneHover;
            stone2.GetComponent<Renderer>().material = stoneHover;
            stone3.GetComponent<Renderer>().material = stoneHover;
            stone4.GetComponent<Renderer>().material = stoneHover;
            hoverLight.SetActive(true);
            pressLight.SetActive(false);
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            GetComponent<Renderer>().material = press;
            stone1.GetComponent<Renderer>().material = stonePress;
            stone2.GetComponent<Renderer>().material = stonePress;
            stone3.GetComponent<Renderer>().material = stonePress;
            stone4.GetComponent<Renderer>().material = stonePress;
            hoverLight.SetActive(false);
            pressLight.SetActive(true);
            StartCoroutine("Back");
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

    IEnumerator Back()
    {
        yield return new WaitForSeconds(0);
        pause.isPaused = false;
    }
}
