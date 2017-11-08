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
	GameObject backForwardToggle;
	IBackForward direction;


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

		backForwardToggle =  GameObject.Find("BackForward");
		direction = Helper.TestIfBackForward(backForwardToggle.gameObject);

        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

    }

    // Update is called once per frame
    void Update ()
	{
	    float speed = transform.rotation.x;


         Debug.Log("accelertion controller transform rotation " +  transform.rotation.x);
        //varannan gång blir det 0, varannan gång rätt värde

        //Check if parking breaks are activated
        //when moving at speed and pressingparkbreaksOn, the speed stops to update
        
        if (!break1.GetToggle(transform.rotation.x))
	    {
	        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
	    }
	    else
	    {
	        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
        if (!break1.GetToggle(speed) && (currentAcc != speed))
        {
            Debug.Log("set speed ");
            currentAcc = transform.rotation.x;
            var dir = direction.GetDirection(speed);

            moveable.UpdatePosition(speed, dir); //object reference not set to instance of object, doesn't run method
			moveable2.UpdatePosition(speed, dir);
        }
    }
}
