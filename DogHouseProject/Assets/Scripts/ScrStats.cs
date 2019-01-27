using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ScrStats : MonoBehaviour {

	public float time;
	public float love;
	public Text timerText;
	public Text loveText;

	public Text timerLabel;
	public Text loveLabel;

    public Text goodBoyLabel;

	public GameObject goalObj;
	
    public UnityEvent MasterIsHomeEvent;

	private ScrGoalDetection goalScript;

    private bool masterDoneAnim;

    private bool levelOver;
    protected ScrLevelManager levelManager;

    // Use this for initialization
    void Start () {
		timerText.text = time.ToString();
		loveText.text = love.ToString();
		goalScript = goalObj.GetComponent<ScrGoalDetection>();
        levelManager = GameObject.FindObjectOfType<ScrLevelManager>();

		loveText.gameObject.SetActive(false);
		loveLabel.gameObject.SetActive(false);
        goodBoyLabel.gameObject.SetActive(false);

        levelOver = false;
        masterDoneAnim = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!levelOver) {
            DoTimeManagment();
        }
	}

    public void DoTimeManagment()
    {
        if (time > 0f)
        {
            if (goalScript.hasArrived)
                time -= Time.deltaTime * 5;
            else
                time -= Time.deltaTime;

            if (time < 0f)
            {
                time = 0f;
                SendMessage("TimeOver");
                print("Master is back!");
                MasterIsHomeEvent.Invoke();
            }
            timerText.text = Math.Round(time, 0).ToString();
        }

        else
        {
            if (!goalScript.hasArrived)
            {
                if (love > 0f)
                {
                    love -= Time.deltaTime;

                    if (love < 0f)
                    {
                        love = 0f;
                    }
                    loveText.text = Math.Round(love / 60 * 100, 0).ToString() + "%";
                }
                else
                {
                    if(levelManager != null)
                        levelManager.GameOver();
                }
            }
            else
            {
                if (love > 0f && masterDoneAnim)
                {
                    print("Goto next level in 2 sec");
                    levelOver = true;
                    goodBoyLabel.gameObject.SetActive(true);
                    Invoke("GotoNextLevel", 2f);
                }
            }

        }
    }

	void TimeOver() {
		loveText.gameObject.SetActive(true);
		loveLabel.gameObject.SetActive(true);
		timerText.gameObject.SetActive(false);
		timerLabel.gameObject.SetActive(false);
        delayMasterDoneAnim(2.5f);
	}

    public void delayMasterDoneAnim(float time) {
        print("master is animating");
        Invoke("setMasterDoneAnim", time);
    }

    void setMasterDoneAnim () {
        print("master should be finished animating");
        masterDoneAnim = true;
    }

    void GotoNextLevel() {
        print("goto next level now");
        if (levelManager != null)
            levelManager.NextLevel();
    }
}
