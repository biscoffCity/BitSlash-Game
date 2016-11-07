using UnityEngine;
using System.Collections;

public class shaker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Stuffz workin???");
		Debug.Log ("Stuffz workin???");
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = new Vector3 (-15, 1, 1);
		transform.localScale = new Vector3 (1, -15, 1);
		transform.localScale = new Vector3 (1, 1, -15);
	}
}
