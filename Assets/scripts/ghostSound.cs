using UnityEngine;
using System.Collections;

public class ghostSound : MonoBehaviour {

	public bool isPlayerInside = false;
	public AudioSource sound;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (isPlayerInside == true) {
			
			if (!sound.isPlaying) {
				Debug.Log ("Play howl sound");
				sound.Play ();
			}

		} else {
			
			if (sound.isPlaying) {
				Debug.Log ("Stop howl sound");
				sound.Stop ();
			}
		}
	
	}


	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.tag == "Player") {
			isPlayerInside = true;
		} 

	}

	void OnTriggerExit2D (Collider2D collider) {

		if (collider.gameObject.tag == "Player") {
			isPlayerInside = false;
		} 
	}
}
