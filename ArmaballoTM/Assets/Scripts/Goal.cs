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
	public Material lockedMat;
	public Material unlockedMat;
	public bool isLocked = true;
	private ActualGyroscopeScript gyroScript;

	void Start(){
		winScreen.enabled = false;
		gyroScript = gameManager.GetComponent<ActualGyroscopeScript> ();
		gameObject.GetComponent<Renderer> ().material.color = lockedMat.color;
	}

	void Update(){
		if (winScreen.enabled) {
			Debug.Log ("RESTART");
			RestartDemo ();
		}
		if (!isLocked) {
			gameObject.GetComponent<Renderer> ().material.color = unlockedMat.color;
		}
	}

	void OnTriggerEnter(Collider col){
		Debug.Log ("COLLIDE");
		if (col.gameObject.tag == "Player" && !isLocked) {
			gyroScript.GyroEnabled = false;
			winScreen.enabled = true;
		}
	}

	//Reloads the scene
	void RestartDemo(){
		if (Input.touchCount >= 1) {
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}
