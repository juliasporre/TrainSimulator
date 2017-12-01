using System.Collections;
using System.Collections.Generic;
using Leap.Unity.InputModule;
using UnityEngine;

public class AccelerationController : MonoBehaviour {

    
    IMoveable moveable;
    GameObject world;
    float currentSpeed;
    GameObject parkBreaks;
    IParkBreaks break1;
	GameObject backForwardToggle;
	IBackForward direction;

    //Sound
    public AudioSource sourceMoving;
    public AudioSource sourceStill;

    bool playMoving = false;

    // Use this for initialization
    void Start () {
        world = GameObject.Find("MoveableWorld");
        moveable = Helper.TestIfMoveable(world.gameObject);

        parkBreaks = GameObject.Find("ParkingBreak");
        break1 = Helper.TestIfParkBreaks(parkBreaks.gameObject);

		backForwardToggle =  GameObject.Find("BackForward");
		direction = Helper.TestIfBackForward(backForwardToggle.gameObject);

        //Starts still
        sourceMoving.Play();
        sourceStill.Play();
        sourceMoving.Pause();

    }

    // Update is called once per frame
    void Update ()
	{
        float speed = Input.GetAxisRaw("Horizontal");

        if (!break1.GetToggle(speed) && Mathf.Abs(currentSpeed - speed) > 0.01)
        {

            // Checks if back or forward
            var dir = direction.GetDirection(speed);

            //Sets angle of the lever model
            transform.eulerAngles = new Vector3(speed - currentSpeed * -60, 0, 0);

            //Updates new current speed
            currentSpeed = speed;

            //Updates the speed
            moveable.UpdatePosition(speed, dir);

            //Sets sound depending on if moving or not
            if (speed == 0 && playMoving == true)
            {
                playMoving = false;
                sourceStill.Play();
                sourceMoving.Pause();
            }
            else if (speed != 0 && playMoving == false)
            {
                playMoving = true;
                sourceMoving.Play();
                sourceStill.Pause();
            }

        }
    }
}
