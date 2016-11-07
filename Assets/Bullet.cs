using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public GameObject turret;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3 (0.1f,0,0);
		//getPostion of bullet less that -7 && greater than 7 {then desotry object} 
		if (transform.position.x >= turret.transform.position.x + 10f || transform.position.x <= turret.transform.position.x - 10f){
			Destroy (this.gameObject);
		}


			
	}


}
