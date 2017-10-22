using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour {

	Color myColor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myColor = gameObject.GetComponent<Text> ().color;
		myColor.a = Mathf.Sin (Time.time);
		gameObject.GetComponent<Text> ().color = myColor;
	}
}
