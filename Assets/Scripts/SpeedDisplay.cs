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

    public void UpdatePosition(float dir)
    {
         speed = Mathf.Round(dir);
    }

    void Update () {
        //Debug.Log("update " + speed);
        speedDisplayText.text = "Speed " + (speed*5).ToString() + " km/h";
    }
}
