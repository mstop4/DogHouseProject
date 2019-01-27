using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrLevelManager : MonoBehaviour {

    private int _currentLevel = 0;
    public string[] Levels = new string[2];
    public string GameOverLevel;

	// Use this for initialization
	void Awake () {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("LevelManager");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if(_currentLevel != 0)
                RestartLevel();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void NextLevel()
    {
        int nextLevel = ++_currentLevel;

        if(nextLevel >= Levels.Length) {
            Debug.LogWarning("No More Levels to Load");
            return;
        }

        string nextLevelKey = Levels[nextLevel];
        _currentLevel = nextLevel;

        SceneManager.LoadScene(nextLevelKey);
    }

    public void RestartLevel()
    {
        string levelKey = Levels[_currentLevel];
        SceneManager.LoadScene(levelKey);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(GameOverLevel);
    }
}
