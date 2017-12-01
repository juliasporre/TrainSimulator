using System;
using System.Collections;
using System.Collections.Generic;
using Boo.Lang.Runtime.DynamicDispatching;
using UnityEngine;

public class moveCube : MonoBehaviour, IMoveable {

    Rigidbody rb;
    private static float constantSpeed;
    private static float currentSpeed;

    private bool currentDirection;

    GameObject speedMeter;
    ISpeedMeter meter;

    Boolean fromZero;

    void Start() {

        rb = GetComponent<Rigidbody>();

        speedMeter = GameObject.Find("indicator");
        meter = Helper.TestIfSpeedMeter(speedMeter.gameObject);
        currentSpeed = 0;
        fromZero = false;
    }
	public void UpdatePosition (float gas, Boolean direction) {

        currentDirection = direction;

		if (gas <= 0) //to be able to stop the train
	    {
	        constantSpeed = 0;
        }
	    else
	    {
			if (direction) { //Moving forward
                constantSpeed = gas * 3;
			}
            else //Moving backwards
			{
                constantSpeed = (-1) * gas;
			}
            fromZero = true;
        }
    }

    void Update()
    {
        //Sets the velocity

        if (currentDirection) //Moves forward
        {
            if (currentSpeed < 0 && fromZero)
            {
                currentSpeed = 0;
                fromZero = false;
            }
            else if (currentSpeed >= 0 && currentSpeed < constantSpeed)
            {
                currentSpeed += 0.01f;
            }
            else if (currentSpeed >= 0 && currentSpeed > constantSpeed)
            {
                currentSpeed -= 0.005f;
            }

        }
        else //Moves backwards
        {
            if (currentSpeed > 0 && fromZero)
            {
                currentSpeed = 0;
                fromZero = false;
            }
            else if (currentSpeed <= 0 && currentSpeed < constantSpeed)
            {
                currentSpeed += 0.005f;
            }
            else if (currentSpeed <= 0 && currentSpeed > constantSpeed)
            {
                currentSpeed -= 0.01f;
            }
        }

        //Updates speed meter
        meter.UpdateSpeedMeter(Math.Abs(currentSpeed /7));
        rb.velocity = (-30) * currentSpeed * Vector3.forward;

    }


}
