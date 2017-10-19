using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationController : MonoBehaviour {

    
    IMoveable moveable;
    GameObject redCube;
    float currentAcc;
    // Use this for initialization
    void Start () {
        redCube = GameObject.Find("REDCUBE");
        moveable = Helper.TestIfMoveable(redCube.gameObject);

        currentAcc = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (currentAcc != transform.rotation.x)
        {
            moveable.UpdatePosition(transform.rotation.x);
        }
    }
}
