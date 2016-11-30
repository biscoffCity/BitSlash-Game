using UnityEngine;
using System.Collections;

public class swordSound : MonoBehaviour {
	public AudioSource sound;
	private float soundTimer = 0;
	private float soundTimerCD = 0.9f;
	private bool soundOn = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("f") && !soundOn) {
			soundOn = true;
			sound.Play ();
			
		}


		if (soundOn) {
			if (soundTimer > 0) {
				soundTimer -= Time.deltaTime;
			} else {
				soundOn = false;
				soundTimer = soundTimerCD;
			}

		}

	
	}
}

