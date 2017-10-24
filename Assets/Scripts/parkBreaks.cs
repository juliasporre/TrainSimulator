using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Leap.Unity.InputModule
{
    public class parkBreaks : MonoBehaviour, IParkBreaks
    {
        public Text text;
        public UnityEngine.UI.Image image;
        //public Color OnColor;
        //public Color OffColor;
        private static Boolean enabled = true;
        private static Boolean breaksOn = true;

        public void SetToggle(Toggle toggle)
        {
            //Debug.Log("Enabled break:" +  enabled);
            
            if (!enabled)
            {
                return;
            }
            //Debug.Log("in setToggle");
            if (toggle.isOn)
            {
                text.text = "Parking Breaks On";
                text.color = Color.white;
                image.color = new Color(0.7f, 0, 0);
                breaksOn = true;
                //to do fix color of button
            }
            else
            {
                text.text = "Parking Breaks Off";
                text.color = new Color(0.3f, 0.3f, 0.3f);
                image.color = new Color(0.86667f, 0.86667f, 0.86667f);
                breaksOn = false;
                //to do enable lever
            }
            //Debug.Log(text.text);
        }

        public bool GetToggle(float rotation)
        {
            if (Math.Abs(rotation) >= 0.03)
            {
               enabled = false;
            }
            else
            {
                enabled = true;
            }
            return breaksOn;
        }

    }
}
