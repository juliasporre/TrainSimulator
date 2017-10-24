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
	public void UpdatePosition (float dir) {
        //Debug.Log("MOVE");

	    if (Math.Abs(dir) < 0.1) //to be able to stop the train
	    {
	        constantSpeed = 0;
	    }
	    else
	    {
	        constantSpeed = dir;
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
