using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrBgmManager : MonoBehaviour {

	private AudioSource bgm;
	private Camera mainCamera;

	// Use this for initialization
	void Awake () {
		GameObject[] objs = GameObject.FindGameObjectsWithTag("BgmManager");

		if (objs.Length > 1)
		{
				Destroy(this.gameObject);
		}

		DontDestroyOnLoad(this.gameObject);
  }
    void OnEnable() {
      SceneManager.sceneLoaded += OnSceneLoaded;
    }

	void Start () {
		bgm = GetComponent<AudioSource>();
		bgm.Play(0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = mainCamera.transform.position;
	}

	void OnSceneLoaded (Scene scene, LoadSceneMode mode) {
		mainCamera = Camera.main;
	}

	void OnApplicationQuit() {
		bgm.Stop();
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}
}
