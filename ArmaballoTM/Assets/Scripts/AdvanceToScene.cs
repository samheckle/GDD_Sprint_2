using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdvanceToScene : MonoBehaviour {

	public string sceneName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// Loads the scene stored in the sceneName field
	/// </summary>
	public void LoadScene(){
		SceneManager.LoadScene (sceneName);
	}

	/// <summary>
	/// Loads a scene with a given name
	/// </summary>
	/// <param name="name">Name.</param>
	public void LoadScene(string name){
		SceneManager.LoadScene (name);
	}
}
