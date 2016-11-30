using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class enemyHealth : MonoBehaviour {

	private int enemyLife = 100;
	public int damage;
	private knightControls player;
	public bool isGhostTakingDamage;
	private float attackTimer = 0;
	private float attackCD = 0.5f;
	public AudioSource sound;
	public Text CountText;
	//private int count;
	 

	void Start () {
		player = GameObject.FindWithTag("Player").GetComponent<knightControls>();
		//count = 0;
		//CountText.text = count.ToString ();
	}

	// Update is called once per frame
	void Update () {
		if (isGhostTakingDamage) {
			if (attackTimer > 0) {
				attackTimer -= Time.deltaTime;
			} else {
				isGhostTakingDamage = false;
			}
		}
	}

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.tag == "sword") {
			enemyLife -= 20;
			isGhostTakingDamage = true;
			attackTimer = attackCD;
		} 

		if (enemyLife <= 0) {
			//
			

			//count += 1;
			CountText.text = "" + (int.Parse(CountText.text) + 1);

			StartCoroutine (KillGhost());
		}
		if (collider.gameObject.tag == "Player" && player.takeDamage == false) {
			sound.Play ();
			player.currentPlayerHealth -= 10;

			if (player.transform.position.x < this.transform.position.x) {

				player.transform.position += new Vector3 (-0.4f, 0, 0);



				//player.rb2d.velocity = new Vector3 (KeyCode.LeftArrow * 0.2f, 0);
				player.rb2d.velocity = new Vector2 (0, 7f);
			} else {

				player.transform.position += new Vector3 (0.4f, 0, 0);
			
				player.rb2d.velocity = new Vector2 (0, 7f);
			} 
			player.gameObject.GetComponent<Animator> ().Play ("takeDamage");
			player.takeDamage = true;
		} 
	}

	public IEnumerator KillGhost ()
	{
		this.gameObject.transform.FindChild ("Particle System").gameObject.SetActive (true);
		this.gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		this.gameObject.GetComponent<BoxCollider2D> ().enabled = false;

		yield return new WaitForSeconds (3f);

		this.gameObject.SetActive (false);
	}
}
