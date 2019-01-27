using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrCameraFollow : MonoBehaviour {
	private Camera mainCamera;
	public Transform t;

	// Use this for initialization
	void Start () {
		mainCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		mainCamera.transform.position = t.position - (Vector3.left * 2f + Vector3.down) * 3f;
	}
}
