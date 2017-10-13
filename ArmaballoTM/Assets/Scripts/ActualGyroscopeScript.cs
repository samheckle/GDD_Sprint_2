using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

public class ActualGyroscopeScript : MonoBehaviour {

	private bool gyroEnabled = false;

	public bool GyroEnabled{
		get{ return gyroEnabled; }
		set{ 
			gyroEnabled = value;
			Input.gyro.enabled = gyroEnabled;
		}
	}

	// Use this for initialization
	void Start () {
		Input.gyro.enabled = false;
		transform.rotation = new Quaternion(0,0,0,0);
		 Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	
	// Update is called once per frame
	void Update () {
		if (gyroEnabled) {
			transform.rotation = GyroToUnity (Input.gyro.attitude);
			//Debug.Log (Input.gyro.attitude);
		}
	}

	//protected void OnGUI()
    //{
    //    GUI.skin.label.fontSize = Screen.width / 40;
	//
    //    GUILayout.Label("Orientation: " + Screen.orientation);
    //    GUILayout.Label("input.gyro.attitude: " + Input.gyro.attitude);
    //    GUILayout.Label("iphone width/font: " + Screen.width + " : " + GUI.skin.label.fontSize);
    //}

	private static Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(-q.x, -q.z, -q.y, q.w);
    }
}
