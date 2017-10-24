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

	    if (Math.Abs(dir) < 0.03) //to be able to stop the train
	    {
	        constantSpeed = 0;
	    }
	    else
	    {
	        constantSpeed = dir;
        }

        Debug.Log("updatePosition" + constantSpeed);
        //var cvel = Vector3.right * dir;
        //var tvel = cvel.normalized;
        //Debug.Log(cvel);
        //Debug.Log(tvel);
        //rigidbody.AddForce(cvel);
        //Debug.Log(dir);
        //rb.velocity = dir * Vector3.right;
        //Debug.Log(rb.velocity);
        //transform.Translate(Vector3.right * dir * Time.deltaTime);
    }

    void Update()
    {
        // Debug.Log("update " + constantSpeed);
        // Debug.Log("vecotor " + Vector3.right);

        rb.velocity = (-30)* constantSpeed * Vector3.forward;
        //Debug.Log(rb.velocity);
    }


}
