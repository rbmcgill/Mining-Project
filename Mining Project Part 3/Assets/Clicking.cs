using UnityEngine;
using System.Collections;

public class Clicking : MonoBehaviour {

	public GameState myState;

	// Use this for initialization
	void Start () {
	
	}

	void OnMouseDown(){
		Destroy (gameObject);

		if (myState == GameState.Bronze) {
			ControlGame.bronzeCount--;
			//If it's bronze time then destroying a bronze cube will subtract 1 from the count
			ControlGame.score += ControlGame.bronzePoints;
		}

		else if (myState == GameState.Silver) {
			ControlGame.silverCount--;
			ControlGame.score += ControlGame.silverPoints;
		}
		
		else if (myState == GameState.Gold) {
			ControlGame.goldCount--;
			ControlGame.score += ControlGame.goldPoints;
		}
		
		else if (myState == GameState.Kryptonite) {
			ControlGame.kryptoniteCount--;
			ControlGame.score += ControlGame.kryptonitePoints;
		}
	



	}

	// Update is called once per frame
	void Update () {
	
	}
}
