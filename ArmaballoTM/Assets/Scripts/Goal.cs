using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
			BackToMenu ();
		}
		if (!isLocked) {
			gameObject.GetComponent<Renderer> ().material.color = unlockedMat.color;
		}
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player" && !isLocked) {
			gyroScript.GyroEnabled = false;
			winScreen.enabled = true;
			//Update the progress in PlayerPrefs
			int temp = PlayerPrefs.GetInt("Progress");
			if (SceneManager.GetActiveScene ().name == "Level" + (temp + 1)) {
				Debug.Log ("PROGRESS LEVEL: " + temp);
				PlayerPrefs.SetInt("Progress",PlayerPrefs.GetInt("Progress")+1);
			}
		}
	}

	//Reloads the scene
	void BackToMenu(){
		if (Input.touchCount >= 1) {
			SceneManager.LoadScene ("LevelSelect");
		}
	}
}
