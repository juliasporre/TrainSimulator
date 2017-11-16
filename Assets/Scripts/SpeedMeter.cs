using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class SpeedMeter : MonoBehaviour, ISpeedMeter
{

    private static float minAngle = -25f;
    private static float maxAngle = 180f;

	public void UpdateSpeedMeter(float gas) {
 
	    float ang = Mathf.Lerp(minAngle, maxAngle, gas);
         transform.localEulerAngles = new Vector3(0, ang, 0);
    }
}
