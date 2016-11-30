 using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class knightControls : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;
	public float jumpBuffer;
	public Vector3 OriginalPosition;
	public int currentPlayerHealth;
	public int maxPlayerHealth;
	public Image healthBar;
	//private bool walk = false; 
	public bool takeDamage;
	private PlayerAttack attackScript;
	private enemyHealth enemyScript;

	public Rigidbody2D rb2d;
	//int numberOfJumps = 2;
	public int numberJumped = 0;
	private float damageTimer = 0;
	private float damageTimerCD = 0.8f;


	void Start () {
		OriginalPosition = transform.position;
		rb2d = GetComponent<Rigidbody2D> ();
		currentPlayerHealth = maxPlayerHealth; 
		attackScript = this.gameObject.GetComponent<PlayerAttack> ();
		enemyScript = this.gameObject.GetComponent<enemyHealth> ();
	}
	 
	void animationController() {
		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.LeftArrow)) {
			if (!this.gameObject.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Base Layer.Walk") && !attackScript.attacking && !takeDamage) {
				Debug.Log ("walk");
				this.gameObject.GetComponent<Animator> ().Play ("Walk");

			}//let me call you on the phone so we can comunicate? okay wait try to run it broh play the game
			//ok wait //le
		} else {
			if (!this.gameObject.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Base Layer.Idle") && !attackScript.attacking && !takeDamage) {
				Debug.Log ("idle");
				this.gameObject.GetComponent<Animator> ().Play ("Idle");
			} //typo broh do it again // not working I see wait
			//can I call u? what's ur number we can call through Team Viewer I think if  I just called can you hear??? I hear you crystal clear but can you hear me?wait let me plug my mic in
		}
	}
	//IF I hold down make it true and if it's not held anymore false 


	void jumpControl () {
		if (Input.GetKeyDown ("up") && numberJumped == 0) {

			Debug.Log ("first jump");

			rb2d.velocity = new Vector2 (0, jumpHeight);
			numberJumped++;
		
		} 
		else if (Input.GetKeyDown ("up") && numberJumped == 1) {

			Debug.Log ("second jump");

			rb2d.velocity = new Vector2 (0, jumpHeight*1.04f);
			numberJumped++;
		}

			
	}


	void Update() {
		if (Input.GetAxisRaw ("Horizontal") == 1) {
			transform.localScale = new Vector3 (1, 1, 1);
		} else if (Input.GetAxisRaw ("Horizontal") == -1) {
			transform.localScale = new Vector3 (-1, 1, 1);
		} 

		// can I jsut call you using phone lol? it will be lot eaiser and more effiecent okay my number 1 347 832 8363
		healthBar.fillAmount = (float)currentPlayerHealth / maxPlayerHealth;

		if (currentPlayerHealth <= 0) {
			die ();
		}

		jumpControl ();

		animationController ();

		if (takeDamage) {
			if (damageTimer > 0) {
				damageTimer -= Time.deltaTime;
			} else {
				takeDamage = false;
				damageTimer = damageTimerCD;
			}
		}
	}

	void FixedUpdate () {
		Vector2 moveDir;
//		if (Input.GetKeyDown ("space")) {
//			moveDir = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed * 3,rb2d.velocity.y);
//			
//		}
		moveDir = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed ,rb2d.velocity.y);
		rb2d.velocity = moveDir;

//		if (Input.GetKeyDown ("up")) {
//			rb2d.AddForce (new Vector2 (0,jumpHeight));
//		}
		//jumpControl ();
	}

	void OnCollisionEnter2D(Collision2D other) {
		
	
		if (other.gameObject.tag == "ground") {
			numberJumped = 0;
		}
	}



//	void OnTriggerEnter2D (Collider2D collider)
//	{
//		if (collider.gameObject.tag == "spikes") {
//			//transform.position = OriginalPosition;
//			currentPlayerHealth = currentPlayerHealth - 10;
//		}
//
//	}



	void die () {
		//SceneManager.LoadScene(SceneManager.GetActiveScene().name);﻿	
		SceneManager.LoadScene (0);
	}
}
