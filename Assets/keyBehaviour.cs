using UnityEngine;
using System.Collections;

public class keyBehaviour : MonoBehaviour {
	public GameObject lockedDoor;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.tag == "Player") {
			lockedDoor.transform.position = new Vector3(77.84f, 6, -0.9923376f);
			Debug.Log ("YOO!!!");
		}
	}
}
