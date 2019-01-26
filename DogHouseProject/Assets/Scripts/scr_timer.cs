using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_timer : MonoBehaviour {

	public float time;
	public Text timerText;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		timerText.text = "Timer: " + time.ToString();
	}
}
