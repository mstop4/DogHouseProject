using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_dogMovement : MonoBehaviour {

	bool arrivedAtGoal;

	// Use this for initialization
	void Start () {
		arrivedAtGoal = false;
	}
	
	// Update is called once per frame
	void Update () {
		int v_input = 0;
		int h_input = 0;

		if (Input.GetKey("up")) v_input += 1;
		if (Input.GetKey("down")) v_input -= 1;
		if (Input.GetKey("right")) h_input += 1;
		if (Input.GetKey("left")) h_input -= 1;

		transform.Translate((Vector3.forward * v_input + Vector3.right * h_input) * Time.deltaTime * 5);

		if (transform.position.x <= -5 && !arrivedAtGoal) {
			arrivedAtGoal = true;
			print("Woof!");
		}
	}
}
