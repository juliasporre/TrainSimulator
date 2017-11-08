using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestJoystick : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("HEJ");
        Debug.Log(Input.GetJoystickNames()[0]);


	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Input.GetAxisRaw("Horizontal"));
    }
}
