using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrBGM : MonoBehaviour {

	private AudioSource bgm;
	private Camera mainCamera;

	// Use this for initialization
	void Start () {
		mainCamera = Camera.main;
		bgm = GetComponent<AudioSource>();
		bgm.Play(0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = mainCamera.transform.position;
	}

	void onDestroy() {
		bgm.Stop();
	}
}
