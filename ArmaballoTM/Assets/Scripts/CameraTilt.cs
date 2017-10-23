using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTilt : MonoBehaviour {

	public GameObject gameObj;
	public GameObject sphere;
	public ActualGyroscopeScript gyroScript;
	// Use this for initialization
	void Start () {
		gyroScript = gameObj.GetComponent<ActualGyroscopeScript>();
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion rotY = transform.rotation;
		rotY.y = gyroScript.rotation.y*-.001f;
		rotY.z = gyroScript.rotation.z*-.001f;
		Vector3 moveX = transform.position;
		// if(moveX.x == sphere.transform.position.x){
		 	//moveX += sphere.transform.position;
		// }
		// else{
		// moveX.x += sphere.transform.position.x*.001f;
		// }
		// rotY.y = gyroScript.rotation.y*.001f;
		// Debug.Log(rotY);
		transform.rotation = rotY;
		transform.position = moveX;
	}
}
