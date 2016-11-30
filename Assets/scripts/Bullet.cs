using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public GameObject turret;
	private knightControls player;
	public AudioSource sound;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player").GetComponent<knightControls>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3 (0.1f,0,0);
		//getPostion of bullet less that -7 && greater than 7 {then desotry object} 
		if (transform.position.x >= turret.transform.position.x + 10f || transform.position.x <= turret.transform.position.x - 10f) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.tag == "Player" && player.takeDamage == false) {
			player.currentPlayerHealth -= 10;
			player.gameObject.GetComponent<Animator> ().Play ("takeDamage");//new
			player.takeDamage = true;//new
			sound.Play();

		}
	} 

}
