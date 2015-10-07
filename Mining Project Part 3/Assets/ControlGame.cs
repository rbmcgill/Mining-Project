using UnityEngine;
using System.Collections;

public class ControlGame : MonoBehaviour {
	public GameObject bronzeCube;
	public GameObject silverCube;
	public GameObject goldCube;
	public GameObject kryptonite;

	public static int bronzeCount = 0;
	public static int silverCount = 0;
	public static int goldCount = 0;
	public static int kryptoniteCount = 0;
	public static int bronzePoints = 1;
	public static int silverPoints = 10;
	public static int goldPoints = 100;
	public static int kryptonitePoints = 1000;
	public static int score = 0;

	private bool recentlySpawnedGold = false;

	float spawnFrequency = 1.2f;
	float timeToAct = 0.0f;
	float spawnSilverTime = 10.0f;
	float stopSpawningTime = 5.0f;
	float spawnGoldTime = 20.0f;
	float spawnKryptoniteTime = 30.0f;

	GameState myState = GameState.Bronze;
	//Ammend kyrptonite time and constraints

	// Use this for initialization
	void Start () {
		timeToAct += spawnFrequency;
		print ("It started!");
	}
	
	// Update is called once per frame
	void Update () {

		if (bronzeCount == 2 && silverCount == 2 && recentlySpawnedGold == false && Time.time >= timeToAct) {
			myState = GameState.Gold;
			Instantiate (goldCube, new Vector3 (Random.Range (-5f, 5f), 0, Random.Range (-2f, 7f)), Quaternion.identity);
			timeToAct += spawnFrequency;
			goldCount++;
			recentlySpawnedGold = true;
			print (Time.time);
			print (myState);
			print (score);
		}

		else if (Time.time >= timeToAct && bronzeCount < 4) {
			myState = GameState.Bronze;
			Instantiate (bronzeCube, new Vector3 (Random.Range (-5f, 5f), 0, Random.Range (-2f, 7f)), Quaternion.identity);
			timeToAct += spawnFrequency;
			bronzeCount++;
			recentlySpawnedGold = false;
			print (Time.time);
			print (myState);
			print (score);
		}
		//If it's time to act and not yet spawning silver and there are less than 4 bronze cubes spawned:
		//spawn the cube anywhere in this range and add the spawn frequency to time to act so the game tracks what time has passed

		else if (Time.time >= timeToAct && bronzeCount >= 4) {
			myState = GameState.Silver;
			Instantiate (silverCube, new Vector3 (Random.Range (-5f, 5f), 0, Random.Range (-2f, 7f)), Quaternion.identity);
			timeToAct += spawnFrequency;
			silverCount++;
			recentlySpawnedGold = false;
			print (Time.time);
			print (myState);
			print (score);
		} 


	
	}
}
