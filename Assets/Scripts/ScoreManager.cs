using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text scoreText2;
    public static int score=0;
    float timer=60f;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        int gameTimer = (int)timer;
        scoreText.text = "Score : " + score;
        scoreText2.text = gameTimer.ToString();

        if (gameTimer == 0)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(2);
        }
    }
}
