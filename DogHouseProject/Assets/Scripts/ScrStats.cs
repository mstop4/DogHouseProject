using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrStats : MonoBehaviour {

	public float time;
	public float love;
	public Text timerText;
	public Text loveText;

	public Text timerLabel;
	public Text loveLabel;

	public GameObject goalObj;
	
	private ScrGoalDetection goalScript;

	// Use this for initialization
	void Start () {
		timerText.text = time.ToString();
		loveText.text = love.ToString();
		goalScript = goalObj.GetComponent<ScrGoalDetection>();

		loveText.gameObject.SetActive(false);
		loveLabel.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (time > 0f) {
			time -= Time.deltaTime;

			if (time < 0f) {
				time = 0f;
				SendMessage("TimeOver");
				print("Master is back!");
			}
			timerText.text = Math.Round(time, 1).ToString();
		}

		else {
			if (!goalScript.hasArrived && love > 0f) {
				love -= Time.deltaTime;

				if (love < 0f) {
					love = 0f;
				}
				loveText.text = Math.Round(love, 1).ToString();
			}
		}
	}

	void TimeOver() {
		loveText.gameObject.SetActive(true);
		loveLabel.gameObject.SetActive(true);
		timerText.gameObject.SetActive(false);
		timerLabel.gameObject.SetActive(false);
	}
}
