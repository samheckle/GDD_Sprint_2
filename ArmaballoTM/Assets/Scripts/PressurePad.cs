using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles the pressure pad feature
/// Authors: Dezmon Gilbert
/// Date: 10/16/2017
/// </summary>
public class PressurePad : MonoBehaviour {

    public GameObject wall;
    bool isActivated;

	// Use this for initialization
	void Start ()
    {
        isActivated = false;
	}
	
	// Update is called once per frame
	void Update ()
    {

    }


    void OnTriggerEnter(Collider col)
    {
        if (isActivated) return;
        if(col.gameObject.tag == "Player")
        {
            isActivated = true;
            DestroyObject(wall);
        }
    }
}
