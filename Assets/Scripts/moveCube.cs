using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCube : MonoBehaviour, IMoveable {

    Rigidbody rb;
    float constantSpeed;
    void Start() {
        rb = GetComponent<Rigidbody>();
        constantSpeed = 0;
        }
	public void UpdatePosition (float dir) {
        //Debug.Log("MOVE");
        constantSpeed = dir;
        Debug.Log(constantSpeed);
        //var cvel = Vector3.right * dir;
        //var tvel = cvel.normalized;
        //Debug.Log(cvel);
        //Debug.Log(tvel);
        //rigidbody.AddForce(cvel);
        //Debug.Log(dir);
        //rb.velocity = dir * Vector3.right;
        //Debug.Log(rb.velocity);
        //transform.Translate(Vector3.right * dir * Time.deltaTime);
    }

    void Update()
    {
        rb.velocity = constantSpeed * Vector3.right;
    }
}
