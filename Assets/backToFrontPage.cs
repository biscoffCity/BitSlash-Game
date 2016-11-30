using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class backToFrontPage : MonoBehaviour {
	public AudioSource sound;
	// Use this for initialization
	void Start () {
		sound.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("return")) {
			SceneManager.LoadScene (0);
		}
	
	}
}
