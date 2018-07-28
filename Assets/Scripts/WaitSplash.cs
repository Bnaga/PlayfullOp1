using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitSplash : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        StartCoroutine("WaitandBleed");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator WaitandBleed()
    {
        yield return new WaitForSeconds(5);
        float fadeTime = GameObject.Find("Fader").GetComponent<Fader>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
