using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCube : MonoBehaviour, IMoveable {
	
	public void UpdatePosition () {
        Debug.Log("MOVING");
        transform.Translate(Vector3.right * Time.deltaTime);
    }
}
