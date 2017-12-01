using System;
using System.Collections;
using System.Collections.Generic;
using Boo.Lang.Runtime.DynamicDispatching;
using UnityEngine;

public class moveCube : MonoBehaviour, IMoveable {

    Rigidbody rb;
    private static float constantSpeed;


    void Start() {

        rb = GetComponent<Rigidbody>();
    }
	public void UpdatePosition (float gas, Boolean direction) {

		if (gas <= 0) //to be able to stop the train
	    {
	        constantSpeed = 0;
        }
	    else
	    {
			if (direction) { //Moving forward
				constantSpeed = gas*5;
			}
            else //Moving backwards
			{
				constantSpeed = (-1) * gas;
			}
        }
    }

    void Update()
    {
        //Sets the velocity
        rb.velocity = (-30)* constantSpeed * Vector3.forward;
    }


}
