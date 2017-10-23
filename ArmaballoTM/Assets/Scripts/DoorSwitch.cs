using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  Author(s): Dezmon Gilbert
///  Date: 10/22/2017
///  Purpose: Will switch between doors to allow one to open while closing the other.
///  How To Use: Attach this script to the switch. Door1 should be a door that is initially open and Door2
///  will initially be closed. Place both doors on the maze where they will be regardless of status as the first
///  door will be moved down upon initilization.
/// </summary>
public class DoorSwitch : MonoBehaviour {

    public GameObject door1;    // this is the door that is initially open
    public GameObject door2;    // this is the door that is initially closed
    private Vector3 door1OriginalPos;   // original postion of door 1
    private Vector3 door2OriginalPos;   // original position of door 2

	// Use this for initialization
	void Start () {
        // obtain the original position of the doors
        door1OriginalPos = door1.transform.position;
        door2OriginalPos = door2.transform.position;
        door1.transform.position = new Vector3(door1OriginalPos.x, -100, door1OriginalPos.z); //moves door1 down below the maze
	}
	
	// Update is called once per frame
	void Update () {}

    //
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            // door1 is in it's original position, set door2 to "open" and door1 to "close"
            if(door1OriginalPos != door1.transform.position)
            {
                // move door2 down
                Vector3 temp = door2OriginalPos;
                temp.y = -100;
                door2.transform.position = temp;

                // set door1 to it's original position
                door1.transform.position = door1OriginalPos;
                return;
            }

            // otherwise, "close" door2 and "open" door1
            if(door2OriginalPos != door2.transform.position)
            {
                // move door1 down
                Vector3 temp = door1OriginalPos;
                temp.y = -100;
                door1.transform.position = temp;

                // set door2 to it's original position
                door2.transform.position = door2OriginalPos;
            }
        }
    }
}
