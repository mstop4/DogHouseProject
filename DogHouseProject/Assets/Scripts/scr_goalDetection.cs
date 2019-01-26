using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_goalDetection : MonoBehaviour {

	bool hasArrived;

	// Use this for initialization
	void Start () {
		hasArrived = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		//if (!hasArrived) {
			//hasArrived = true;
			print("woof!");
		//}
	}
}
