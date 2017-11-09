using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;


public class SpeedMeter : MonoBehaviour, ISpeedMeter
{
    private static float speed;
    private static float rotation;
    private static float delta;
    private static float minAngle = -45f;
    private static float maxAngle = 180f;
    // Use this for initialization
    void Start ()
    {
        speed = 0;
    }
	
	public void UpdateSpeedMeter(float gas) {
        //get the current speed
        if (gas <= 0) //to be able to stop the train
	    {
	        speed = minAngle;
	
	    }
	    else {
	        speed = gas * 5;

        }
	    float ang = Mathf.Lerp(minAngle, maxAngle, gas);
        transform.eulerAngles = new Vector3(0, 0, -ang); //game object changes shape, but moves in the desired way


        //rotation = startPos + speed * 1.4f;
        /*  Debug.Log("delta "+delta);
          Debug.Log("rotation "+rotation); //this is always 0
          Debug.Log("start pos "+transform.rotation.y);*/
      //    transform.Rotate(0, -ang, 0, Space.Self); //game object maintains shape, but spins in the wrong directions, very wierd
    }
}
