using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles main game logic.
/// Authors: Nik Whiteside
/// Date: 10/10/2017
/// </summary>
public class GameManager : MonoBehaviour {

	public Canvas tutorial;
	public ActualGyroscopeScript gyroScript;

	// Use this for initialization
	void Start () {
		gyroScript = gameObject.GetComponent<ActualGyroscopeScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (tutorial.enabled) {
			BeginGame ();
		}
	}

	/// <summary>
	/// Starts the game when the player taps the screen
	/// </summary>
	void BeginGame(){
		if (Input.touchCount >= 1) {
			tutorial.enabled = false;
			gyroScript.GyroEnabled = true;
		}
	}
}
