using UnityEngine;
using System.Collections;

public class spikes : MonoBehaviour {

	public AudioSource sound;
	private knightControls player;
	private Rigidbody2D rb2d;
	public int damage;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player").GetComponent<knightControls>();
		rb2d = GameObject.FindWithTag ("Player").GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.tag == "Player" && player.takeDamage == false) {
			//player.transform.position += new Vector3 (0, 3f, 0);
			//player.transform.Translate(Vector3.up * Time.deltaTime);
			rb2d.velocity = new Vector2 (0, 7f);
			player.currentPlayerHealth -= damage;
			sound.Play ();
			player.gameObject.GetComponent<Animator> ().Play ("takeDamage");//new
			player.takeDamage = true;//new
		}
	}
}
