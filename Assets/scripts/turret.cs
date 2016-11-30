using UnityEngine;
using System.Collections;

public class turret : MonoBehaviour {

	public GameObject bullet;
	public bool isPlayerInside = false;


	// Use this for initialization
	void Start () 
	{
		StartCoroutine (StartShooting());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator StartShooting () {
		while(true) {
			if (isPlayerInside) {
				GenerateBullets ();
			}
			yield return new WaitForSeconds (1.3f);
		}
	}

	void GenerateBullets() {
		GameObject newBullet = Instantiate (bullet); //copies and paste the bullet 
		newBullet.transform.position = new Vector2(transform.position.x-0.6f,transform.position.y-0.4f);
		//newBullet.transform.position.y = transform.position.y;
		newBullet.SetActive (true);
	}

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.tag == "Player") {
			isPlayerInside = true;
			//StartCoroutine (StartShooting());
		} 
		
	}

	void OnTriggerExit2D (Collider2D collider) {
		
		if (collider.gameObject.tag == "Player") {
			isPlayerInside = false;
		} 
	} 
}
