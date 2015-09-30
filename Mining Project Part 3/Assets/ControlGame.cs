using UnityEngine;
using System.Collections;

public class ControlGame : MonoBehaviour {
	public GameObject bronzeCube;
	public GameObject silverCube;
	public GameObject goldCube;
	public GameObject kyrptonite;

	float spawnFrequency = 1.5f;
	float timeToAct = 0.0f;
	float spawnSilverTime = 10.0f;
	float stopSpawningTime = 5.0f;
	float spawnGoldTime = 20.0f;
	float spawnKryptoniteTime = 30.0f;
	//Ammend kyrptonite time and constraints

	// Use this for initialization
	void Start () {
		timeToAct += spawnFrequency;
		print ("It started!");
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= timeToAct && Time.time < spawnSilverTime + stopSpawningTime) {
			Instantiate(bronzeCube, new Vector3 (Random.Range(-5f, 5f),0,Random.Range (-2f, 7f)), Quaternion.identity);
			timeToAct += spawnFrequency;
			print ("A bronze cube spawned!");
			print (Time.time);
		}

		if (Time.time >= timeToAct && Time.time < spawnGoldTime + stopSpawningTime) {
			Instantiate(silverCube, new Vector3 (Random.Range(-5f, 5f),0,Random.Range (-2f, 7f)), Quaternion.identity);
			timeToAct += spawnFrequency;
			print ("A silver cube spawned!");
			print (Time.time);
		}
	}
}
