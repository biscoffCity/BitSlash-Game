using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

	public bool attacking = false;

	private float attackTimer = 0;
	private float attackCD = 0.3f;

	public Collider2D attackTrigger;
	//private Animator anim; 
	public GameObject swordArea;

	void Awake() {
		//anim = gameObject.GetComponent<Animator> ();
		attackTrigger.enabled = false;
		//swordArea.active = false;
		swordArea.SetActive (false);
	}


	void Update() {
		if (Input.GetKeyDown ("f") && !attacking) {
			
			this.gameObject.GetComponent<Animator> ().Play ("Attack");

			attacking = true;
			attackTimer = attackCD; //set attack timer to attack cool down
			attackTrigger.enabled = true;
			//swordArea.active = true;
			swordArea.SetActive (true);
		
		}

		if (attacking) {
			if (attackTimer > 0) {
				attackTimer -= Time.deltaTime;
			} else {
				attacking = false;
				attackTrigger.enabled = false;
				//swordArea.active = false;
				swordArea.SetActive (false);
			}

		}
	}
}
