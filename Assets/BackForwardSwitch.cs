using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackForwardSwitch : MonoBehaviour {

    private static float minAngle = -45f;
    private static float maxAngle = 45f;
    private static float midAngle = 0;
    private static int direction = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if no force, return

        
        // as soon as force is applied, move to next position
        //pseudocode
	/*    if (direction== -1 && forcefromleft)
	    {
	        float ang = Mathf.Lerp(minAngle, maxAngle, midAngle);
	        direction = 0;
	    } else if
	        (direction == 0 && forcefromleft)
	    {
	        float ang = Mathf.Lerp(minAngle, maxAngle, maxAngle);
	        direction = 1;
	    } else if
	        (direction == 1 && forcefromright)
	    {
	        float ang = Mathf.Lerp(minAngle, maxAngle, midAngle);
	        direction = 0;
	    } else if
	        (direction == 0 && forcefromright)
	    {
	        float ang = Mathf.Lerp(minAngle, maxAngle, minAngle);
	        direction = -1;
	    }
	    
	    transform.localEulerAngles = new Vector3(ang, 0, 0);

	    //sound feedback when in position
        */
    }



    public int getDirection()
    {
        return direction;

    }
}
