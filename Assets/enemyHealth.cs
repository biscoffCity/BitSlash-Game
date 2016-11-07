using UnityEngine;
using System.Collections;

public class enemyHealth : MonoBehaviour {
	public bool takeDamage = false;

	private int enemyLife = 100;
	public int damage;
	//private GameObject player;
	private knightControls player;

	// Use this for initialization
	void Start () {
		//GameObject enemy = GameObject.FindGameObjectsWithTag ("ene");
		player = GameObject.FindWithTag("Player").GetComponent<knightControls>();

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.tag == "sword") {
			enemyLife -= 20;
		}
		if (enemyLife <= 0) {
			Debug.Log ("LOLOL!");
			this.gameObject.SetActive (false);

		}
		if (collider.gameObject.tag == "Player") {
			player.currentPlayerHealth -= 10;
			//player.transform.position -= new Vector3 (0.2f, 0, 0);
			//if my x postion is greater than ghost X value push me towards the right 
			//if my postion x is less than the ghost push me left 
			//

			if (player.transform.position.x < this.transform.position.x) {
				player.transform.position += new Vector3 (-0.2f, 0, 0);
			} else {
				player.transform.position += new Vector3 (0.2f, 0, 0);
			} 
			player.gameObject.GetComponent<Animator> ().Play ("takeDamage");
			takeDamage = true;
		}
	}
}
