using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class gameWin : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.tag == "Player") {
			SceneManager.LoadScene (3);
			Debug.Log ("trezzz??");
		}
	}
}
