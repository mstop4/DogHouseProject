using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bark : MonoBehaviour {

    public AudioSource audio;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audio.Play();
        }

    }
}
