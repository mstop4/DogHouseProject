using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrStats : MonoBehaviour {

	public float time;
	public float love;
	public Text timerText;
	public Text loveText;

	// Use this for initialization
	void Start () {
		timerText.text = time.ToString();
		loveText.text = love.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if (time > 0f) {
			time -= Time.deltaTime;

			if (time < 0f) {
				time = 0f;
			}
			timerText.text = time.ToString();
		}

		else {
			if (love > 0f) {
				love -= Time.deltaTime;

				if (love < 0f) {
					love = 0f;
				}
				loveText.text = love.ToString();
			}
		}
	}
}
