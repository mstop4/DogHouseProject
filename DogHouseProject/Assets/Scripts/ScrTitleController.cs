using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ScrTitleController : MonoBehaviour {

    protected ScrLevelManager levelManager;

    // Use this for initialization
    void Start () {
        levelManager = GameObject.FindObjectOfType<ScrLevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
            levelManager.NextLevel();
		}
	}
}
