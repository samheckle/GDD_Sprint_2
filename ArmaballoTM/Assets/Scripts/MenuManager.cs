using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

	public List<GameObject> buttons;
	private int playerProgress;

	// Use this for initialization
	void Start () {
		InitializeButtons ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// Sets up level-select buttons dependent o
	/// player progress.
	/// </summary>
	void InitializeButtons(){
		//Set progress to current stored in PlayerPrefs, otherwise set it to zero
		playerProgress = PlayerPrefs.GetInt ("Progress", 0);
		//Loop through and activate the buttons available
		for (int i = 0; i < playerProgress + 1; i++) {
			buttons [i].GetComponent<Button> ().interactable = true;
		}
	}
}
