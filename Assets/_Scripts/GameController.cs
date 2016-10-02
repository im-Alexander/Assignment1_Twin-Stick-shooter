using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

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
	public Text gameOverLabel;
	public Text finalScore;
	public Text finalWave;
	private string waveWaves; //waveWaves is used to decide if the player lost on wave 1
	public Button reset;
	// The values we'll be printing
	private int score = 0;
	private int waveNumber = 0;
	private int hp = 10;

	[Header("Game Objects")]
	public GameObject duck;

    // Use this for initialization
    void Start()
    {
		this.gameOverLabel.gameObject.SetActive (false);
		this.finalScore.gameObject.SetActive (false);
		this.finalWave.gameObject.SetActive (false);
		this.reset.gameObject.SetActive (false);
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {

    }

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
                //This will display the wave number
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
                // This will increase the amount of enemies per wave
				enemiesPerWave *= 1.3;
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
		if (this.hp <= 0) {
			this._endGame ();
		} else {
			hpText.text = "Health: " + hp + "/10";
		}
	}

	//This will display the game over text
	private void _endGame (){
		this.gameOverLabel.gameObject.SetActive (true);
		this.finalScore.text = "Final Score: " + this.score;
		this.finalScore.gameObject.SetActive (true);
		this.scoreText.gameObject.SetActive (false);
		this.waveText.gameObject.SetActive (false);
		this.hpText.gameObject.SetActive (false);
		this.duck.gameObject.SetActive (false);
		this.reset.gameObject.SetActive (true);
		//This will choose the appropriate text
		if (waveNumber > 1) {
			waveWaves = "waves";
		}
		else{
			waveWaves = "wave";
		}
		this.finalWave.text = "You survived " + this.waveNumber + " " + this.waveWaves + " before you got rekt!";
		this.finalWave.gameObject.SetActive (true);
	}

	//This will reset my scene when the restart button is clicked
	public void restart_Click (){
		SceneManager.LoadScene ("Game");
	}
}
