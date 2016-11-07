using UnityEngine;
using System.Collections;

public class HoldPlayerInPlatform : MonoBehaviour {

	public GameObject knightBoyz; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D collider) {
		if (collider.gameObject.tag == "Player") {
			//make player child 
			knightBoyz.transform.parent = this.gameObject.transform;

		}

	}

	void OnCollisionExit2D (Collision2D collider) {
		if (collider.gameObject.tag == "Player") {
			//make player not a child of the platform
			knightBoyz.transform.parent = null;
		}
	}
}
