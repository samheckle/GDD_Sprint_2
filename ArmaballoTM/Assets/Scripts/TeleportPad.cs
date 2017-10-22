using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  Author(s): Dezmon Gilbert
///  Date: 10/22/2017
///  Purpose: Will teleport player between pads. Can attach to one or both pads.
/// </summary>

public class TeleportPad : MonoBehaviour {

    public GameObject otherPad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col){
        if (col.gameObject.tag == "Player") {
            // moves the play to the other pad
            col.gameObject.transform.position = otherPad.transform.position;

            // turn off the collider for the other pad to prevent being stuck between the two pads
            otherPad.GetComponent<Collider>().enabled = false;

            // turn the collider back on for the other pad after x seconds
            StartCoroutine(ExecuteAfterTime(4f));
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        otherPad.GetComponent<Collider>().enabled = true;
    }
}
