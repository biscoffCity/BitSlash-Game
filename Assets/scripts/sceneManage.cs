using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class sceneManage : MonoBehaviour {


	// Use this for initialization
	void Start () {
		

		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			SceneManager.LoadScene (1);
		}
		if (Input.GetKeyDown("return")) {
			SceneManager.LoadScene (2);
		}

	}

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.tag == "Player") {
			SceneManager.LoadScene (0);
		}
	}
}
