using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

	//Variables
	public Transform enemy; // Our enemy to spawn

	[Header("Wave Properties")]
	public float timeBeforeSpawning = 1.5f;
	public float timeBetweenEnemies = .25f;
	public float timeBeforeWaves = 2.0f;
	public double enemiesPerWave = 10;
	private int currentNumberOfEnemies = 0;

	[Header("User Interface")]
	// The actual GUI text objects
	public Text scoreText;
	public Text waveText;
	public Text hpText;
	// The values we'll be printing
	private int score = 0;
	private int waveNumber = 0;
	private int hp = 10;

	//This Corutine will spawn in the enemies
	IEnumerator SpawnEnemies (){
		//Give the player time before the start of the game
		yield return new WaitForSeconds(timeBeforeSpawning);

		//After timeBeforeSpawning has ended, we will enter this loop
		while(true) 
		{
			//This will check if there are any enemies left on the feild
			if (currentNumberOfEnemies <= 0) 
			{
				waveNumber++;
				waveText.text = "Wave: " + waveNumber;
				//This will spawn 10 enemies in a random position
				for (int i = 0; i < enemiesPerWave; i++) 
				{
					//We want the enimies to be off screen so they do not spawn on the character
					float randDistance = Random.Range(10, 25);

					// Enemies will come from any direction
					Vector2 randDirection = Random.insideUnitCircle;
					Vector3 enemyPos = this.transform.position;

					// Using the distance and direction we set the position
					enemyPos.x += randDirection.x * randDistance;
					enemyPos.y += randDirection.y * randDistance;

					// Spawn the enemy and increase the number of enemies spawned
					Instantiate(enemy, enemyPos, this.transform.rotation);
					currentNumberOfEnemies++;
					yield return new WaitForSeconds (timeBetweenEnemies);
				}
				enemiesPerWave *= 1.3;
				//Enemy_Behavior controller2 = GameObject.FindGameObjectWithTag ("GameController").GetComponent<Enemy_Behavior>();
				//controller2.HpIncrease ();
			}
			//How much time to wait before checking if we need to spawn another wave
			yield return new WaitForSeconds(timeBeforeWaves);
		}
	}

	// Destroys 1 enemy
	public void KilledEnemy()
	{
		currentNumberOfEnemies--;
	}

	//Increases score
	public void IncreaseScore(int increase)
	{
		score += increase;
		scoreText.text = "Score: " + score;
	}

	//Lose 1 hp per hit
	public void DecreaseHp(int decrease)
	{
		hp -= decrease;
		hpText.text = "Health: " + hp + "/10";
	}

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnEnemies ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
