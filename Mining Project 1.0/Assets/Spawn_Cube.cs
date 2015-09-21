using UnityEngine;
using System.Collections;

public class Spawn_Cube : MonoBehaviour {

	public GameObject cube;
	bool cubeSpawned = false;
	// Use this for initialization
	void Start () {
		print ("It started!");
	}
	// Update is called once per frame
	void Update () {
		print ("It updated!");
		if (Time.time > 3 && cubeSpawned == false) {
			Instantiate(cube, new Vector3(0,0,0), Quaternion.identity);
			//spawn the cube please
			print ("Spawned a cube!");
			cubeSpawned = true;
			print ("Cubes stopped spawning.");
		}
	}
}
