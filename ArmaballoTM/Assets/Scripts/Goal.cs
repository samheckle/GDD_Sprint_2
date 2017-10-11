using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles all level-ending behavior when the player
/// reaches the goal
/// </summary>
public class Goal : MonoBehaviour {

	public GameObject ball;
	public Canvas winScreen;
	public GameObject gameManager;
	private ActualGyroscopeScript gyroScript;

	void Start(){
		winScreen.enabled = false;
		gyroScript = gameManager.GetComponent<ActualGyroscopeScript> ();
	}

	void OnTriggerEnter(Collider col){
		Debug.Log ("COLLIDE");
		if (col.gameObject.tag == "Player") {
			gyroScript.GyroEnabled = false;
			winScreen.enabled = true;
		}
	}
}
