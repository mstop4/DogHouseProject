using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_goalDetection : MonoBehaviour {

	public bool hasArrived;
	public bool levelFinished;

	// Use this for initialization
	void Start () {
		hasArrived = false;
		levelFinished = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			hasArrived = true;
			print("arf!");
		}
	}

	void OnTriggerLeave(Collider other) {
		if (other.tag == "Player") {
			hasArrived = false;
			print("woof?");
		}
	}
}
