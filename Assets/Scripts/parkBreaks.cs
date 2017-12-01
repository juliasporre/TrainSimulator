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
        private static Boolean ok = true;
        private static Boolean breaksOn = true;

        public void SetToggle(Toggle toggle)
        {
            if (!enabled)
            {
                return;
            }
            if (toggle.isOn)
            {
                text.text = "Parking Breaks On";
                text.color = Color.white;
                image.color = new Color(0.7f, 0, 0);
                breaksOn = true;
            }
            else
            {
                text.text = "Parking Breaks Off";
                text.color = new Color(0.3f, 0.3f, 0.3f);
                image.color = new Color(0.86667f, 0.86667f, 0.86667f);
                breaksOn = false;
            }
        }

        public bool GetToggle(float rotation)
        {
            if (Math.Abs(rotation) > 0.1)
            {
               ok = false;
            }
            else
            {
                ok = true;
            }
            return breaksOn;
        }

    }
}
