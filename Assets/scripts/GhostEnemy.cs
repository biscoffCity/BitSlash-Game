using UnityEngine;
using System.Collections;

public class GhostEnemy : MonoBehaviour {

	private bool isMovingRight = false;
	private float initialX;
	// Use this for initialization

	void Start () {
		initialX = transform.position.x;

	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.x >= initialX + 2f) {
			isMovingRight = false;	
		} 

		if (transform.position.x <= initialX - 2f) {
			isMovingRight = true;
		}
			
		if (isMovingRight) {
			transform.localScale = new Vector3 (-3, 3, 1); 
			transform.position += new Vector3(0.02f,0,0);
		} else {
			transform.localScale = new Vector3 (3, 3, 1);
			transform.position -= new Vector3(0.02f,0,0);
		}

	}
}
