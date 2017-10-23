using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour {

	public GameObject panel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenClose(){
		if (panel.activeInHierarchy) {
			panel.SetActive (false);
		} else {
			panel.SetActive(true);
		}
	}
}
