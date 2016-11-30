using UnityEngine;
using System.Collections;

public class MainThemeSong : MonoBehaviour {
	public AudioSource audio;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
