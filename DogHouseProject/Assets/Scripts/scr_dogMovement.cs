using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_dogMovement : MonoBehaviour {

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		int v_input = 0;
		int h_input = 0;

		if (Input.GetKey("up")) v_input += 1;
		if (Input.GetKey("down")) v_input -= 1;
		if (Input.GetKey("right")) h_input += 1;
		if (Input.GetKey("left")) h_input -= 1;

		rb.velocity = new Vector3(-v_input * 250 * Time.deltaTime, rb.velocity.y, h_input * 250 * Time.deltaTime);

		//transform.Translate((Vector3.forward * v_input + Vector3.right * h_input) * Time.deltaTime * 5);
	}
}
