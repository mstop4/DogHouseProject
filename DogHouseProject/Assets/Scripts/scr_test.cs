using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other) {
		print("Enter");
	}

	void OnTriggerStay(Collider other) {
		print("Stay");
	}

	void OnTriggerExit(Collider other) {
		print("Exit");
	}
}
