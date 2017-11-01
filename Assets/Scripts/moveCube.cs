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
       // constantSpeed = 0;
        }
	public void UpdatePosition (float gas, Boolean direction) {
        //Debug.Log("MOVE");

		if (gas <= 0) //to be able to stop the train
	    {
	        constantSpeed = 0;
	    }
	    else
	    {
			if (direction) {
				constantSpeed = gas;
			} else 
			{
				constantSpeed = (-1) * gas;
			}
        }
    }

    void Update()
    {
        // Debug.Log("update " + constantSpeed);
        // Debug.Log("vecotor " + Vector3.right);

        rb.velocity = (-30)* constantSpeed * Vector3.forward;
        //Debug.Log(rb.velocity);
    }


}
