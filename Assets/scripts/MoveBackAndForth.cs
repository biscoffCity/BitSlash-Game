using UnityEngine;
using System.Collections;

public class MoveBackAndForth : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
//	private bool dirRight = true;
//	public float speed = 2.0f;
//	public Transform farEnd;
//	void Start () {
//
//	}
//
//	void Update () {
//		if (dirRight) {
//			transform.Translate (Vector2.right * speed * Time.deltaTime);
//
//		} else {
//			transform.Translate (Vector2.left * speed * Time.deltaTime);
//
//		}
//			
//
//		if(transform.position.x >= farEnd.position.x) {
//			dirRight = false;
//			Debug.Log ("Hello");
//		}
//
//		if(transform.position.x <= -farEnd.position.x) {
//			dirRight = true;
//		}
//	}
	private Vector3 pos1 = new Vector3(-4,0,0);
	private Vector3 pos2 = new Vector3(4,0,0);
	public float speed = 1.0f;

	void Update() {
		transform.position = Vector3.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
	}
}
