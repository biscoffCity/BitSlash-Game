using UnityEngine;
using System.Collections;


public class ladder : MonoBehaviour {
	
	public int climbSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D other) {
		if (other.tag == "Player" && Input.GetKey (KeyCode.UpArrow)) {
			other.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, climbSpeed);
		} else if (other.tag == "Player" && Input.GetKey (KeyCode.DownArrow)) {
			other.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -climbSpeed);
		} else {
			other.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0.6f);
		}


	}

}
