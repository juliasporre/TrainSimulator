using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedDisplay : MonoBehaviour, IMoveable {

	private static float speed;
    public Text speedDisplayText;

    void Start () {
        speed = 0;
        speedDisplayText.text = "Speed " + speed.ToString() + " km/h";
    }

	public void UpdatePosition(float gas, Boolean dir)
    {
        if (gas <= 0) //to be able to stop the train
        {
			speed = 0;
        }
        else {
        
			if (dir) 
			{
				speed = Mathf.Round (gas) * 5;
			} 
			else 
			{
				speed = Mathf.Round(gas) * -5;
			}
		}
        
        //when speed os 5 0r 10, display 0
		/*
        if (speed == 5 || speed == -5 || speed == 10 || speed == -10)
        {
            speed = 0;
        }
        */
    }

    void Update () {
        //Debug.Log("update " + speed);
        speedDisplayText.text = "Speed " + speed.ToString() + " km/h";
    }
}
