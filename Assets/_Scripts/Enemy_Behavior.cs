using UnityEngine;
using System.Collections;

public class Enemy_Behavior : MonoBehaviour {
	
	public int health = 1; // The amount of hits beofre the enemy is destroyed
	public Transform explosion; // Play this explosion when enemy dies.
	public AudioClip hitSound; // The sound when hit
	private GameController controller; //Used for linking to the game controller

	// Use this for initialization
	void Start () {
		controller = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController>();
	}

	// Update is called once per frame
	void Update () {

	}

	// This is when a collision occurs with a duck_laser and an enemy.
	void OnCollisionEnter2D(Collision2D theCollision)
	{

		//Uncomment this line to check for collision
		//Debug.Log("Hit by: "+ theCollision.gameObject.name);
		if (theCollision.gameObject.name.Contains ("Duck_Ship")) 
		{
			controller.DecreaseHp (1);
		}
			
		//this line looks for "Laser" in the names of anything collided
		if (theCollision.gameObject.name.Contains ("Laser")) 
		{
			Duck_laser_beam laser = theCollision.gameObject.GetComponent ("Duck_laser_beam") as Duck_laser_beam;
			health -= laser.damage;
			Destroy (theCollision.gameObject);

			//Plays a sound from this objects AudioSource
			GetComponent<AudioSource>().PlayOneShot(hitSound);
		}

		//If the ship hits 0 hp then it will be destroyed
		if (health <= 0) 
		{
			//This will check if the explotion is set.
			if (explosion) 
			{
				GameObject exploder = ((Transform)Instantiate (explosion, this.transform.position, this.transform.rotation)).gameObject;
				Destroy (exploder, 2.0f);
			}

			Destroy (this.gameObject);
			GameController controller = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController>();
			controller.KilledEnemy();

			controller.IncreaseScore (10);
		}
	}

	// Increases the hp each round
	public void HpIncrease()
	{
		health++;
	}
}
