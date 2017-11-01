using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Leap.Unity.InputModule
{
	public class BackForwardToggle : MonoBehaviour, IBackForward
	{
		//icke-intuitiv design?
		public Text text;
		public UnityEngine.UI.Image image;
		public Color OnColor;
		public Color OffColor;
		private static Boolean forward = true;
		private static Boolean enabled = true;

		public void SetToggle(Toggle toggle)
		{
			if (!enabled)
			{
				return;
			}
			//Debug.Log("in setToggle");
			if (toggle.isOn)
			{
				text.text = "Forward";
				text.color = Color.white;
				image.color = new Color(0.57f, 0.57f, 0.57f);
				forward= true;
			}
			else
			{
				text.text = "Back";
				text.color = new Color(0.3f, 0.3f, 0.3f);
				image.color = new Color(0.87f, 0.87f, 0.87f);
				forward = false;
				//to do enable lever
			}
			//Debug.Log(text.text);
		}

		public bool GetDirection(float speed)
		{
			if (speed <= 0) {
				enabled = true;
			} 
			else 
			{
				enabled = false;
			}

			return forward;
		}

	}
}

