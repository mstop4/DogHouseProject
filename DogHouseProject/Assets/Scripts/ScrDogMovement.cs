using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrDogMovement : MonoBehaviour {

	private Rigidbody rb;
	private Camera mainCamera;
	private const float maxSpeed = 5f;

	public GameObject goalObj;
	private ScrGoalDetection goalScript;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		mainCamera = Camera.main;
		goalScript = goalObj.GetComponent<ScrGoalDetection>();
	}
	
	// Update is called once per frame
	void Update () {
		float v_input = Input.GetAxis("Vertical");
		float h_input = Input.GetAxis("Horizontal");

		rb.AddForce((h_input * Vector3.forward - v_input * Vector3.right) * Time.deltaTime * 1000);
		rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
		mainCamera.transform.position = transform.position - (Vector3.left * 1.5f + Vector3.down) * 3f;

		if (Input.GetAxis("Fire1") > 0f) {
			if (!goalScript.levelFinished) {
				if (goalScript.hasArrived) {
					print("Finish!");
					goalScript.levelFinished = true;
					Invoke("SwitchScene", 2f);
				}

				else {
					print("Nope");
				}
			}
		}
	}

	void SwitchScene () {
		print("Scene change");
		SceneManager.LoadScene("Goal");
	}
}
