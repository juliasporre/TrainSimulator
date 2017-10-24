using System.Collections;
using System.Collections.Generic;
using Leap.Unity.InputModule;
using UnityEngine;

public class AccelerationController : MonoBehaviour {

    
    IMoveable moveable;
    GameObject redCube;
    IMoveable moveable2;
    GameObject speedDisplay;
    float currentAcc;
    GameObject parkBreaks;
    IParkBreaks break1;


   // GameObject parkingBreaks;
    //to do inerface for breaks

    // Use this for initialization
    void Start () {
        redCube = GameObject.Find("REDCUBE");
        moveable = Helper.TestIfMoveable(redCube.gameObject);

        currentAcc = 0;
        speedDisplay = GameObject.Find("SpeedDisplay");
        moveable2 = Helper.TestIfMoveable(speedDisplay.gameObject);

        parkBreaks = GameObject.Find("ParkingBreak");
        break1 = Helper.TestIfParkBreaks(parkBreaks.gameObject);

    }

    // Update is called once per frame
    void Update ()
	{
	    float speed = (30) * transform.rotation.x;
        // Debug.Log("accelertion controller " +  transform.rotation.x);
        //Check if parking breaks are activated
        //when moving at speed and pressingparkbreaksOn, the speed stops to update
        if (!break1.GetToggle(transform.rotation.x) && (currentAcc != transform.rotation.x))
        {
            currentAcc = transform.rotation.x;
            moveable.UpdatePosition(transform.rotation.x);
            moveable2.UpdatePosition(speed);
        }
    }
}
