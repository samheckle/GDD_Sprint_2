using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Controls the behavior of the ball object
/// Authors: Nik Whiteside
/// Date: 10/10/2017
/// </summary>
public class BallManager : MonoBehaviour {

	public Vector3 origin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		OutOfBounds ();
	}

	/// <summary>
	/// Returns the ball to the origin if it is
	/// out of bounds
	/// </summary>
	void OutOfBounds(){
		if (gameObject.transform.position.y < -10) {
			Handheld.Vibrate();
			gameObject.transform.position = origin;
		}
	}
}
