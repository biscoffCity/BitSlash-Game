using UnityEngine;
using System.Collections;

public class ghostAnimation : MonoBehaviour {

	private enemyHealth ghost;

	// Use this for initialization
	void Start () {
		ghost = this.gameObject.GetComponent<enemyHealth> ();
	}
	
	// Update is called once per frame
	void Update () {
		ghostAnimationColtrol ();
	}

	void ghostAnimationColtrol () {
		if (ghost.isGhostTakingDamage == true) {
			this.gameObject.GetComponent<Animator> ().Play ("hurtinGhost");
		} else if (ghost.isGhostTakingDamage == false) {
			this.gameObject.GetComponent<Animator> ().Play ("GhostIdle");
		}
	}


}
