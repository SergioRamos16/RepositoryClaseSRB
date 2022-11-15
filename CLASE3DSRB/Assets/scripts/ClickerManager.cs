using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerManager : MonoBehaviour
{
    public GameObject startPanel, gamePanel, endPanel;
    public Text timeLeftText;
    public float playTime;
    private float timeLeft;
    private bool timeIsTicking = false;
    private int numberOfClicks = 0;
    public int targetNumberOfClicks = 10;
    public Text numberOfClicksText;
    public Text gameOverText;
    private string maxScoreKey = "maxScore";

    private void Start()
    {
    }

    public void Click()
    {
        numberOfClicks++;
        numberOfClicksText.text = numberOfClicks.ToString();
    }

    public void Restart()
    {
        numberOfClicks = 0;
        numberOfClicksText.text = numberOfClicks.ToString();
    }

    public void StartCountDown()
    {
        timeLeft = playTime;
        timeIsTicking = true;
    }

    // Update is called once per frame
    private void Update()
    {
        if (timeIsTicking)
        {
            timeLeft -= Time.deltaTime;
            timeLeftText.text = timeLeft.ToString("0.00");
            if (timeLeft < 0)
            {
                timeIsTicking = false;
                GameOver();
            }
        }
    }

    private void GameOver()
    {
        gamePanel.SetActive(false);
        endPanel.SetActive(true);
        CheckWinningConditions();
    }

    private void CheckWinningConditions()
    {
        if (numberOfClicks >= targetNumberOfClicks)
        {
            int maxScore = PlayerPrefs.GetInt(maxScoreKey);
            if (numberOfClicks > maxScore)
            {
                gameOverText.text = " ¡ENHORABUENA! Has conseguido " + numberOfClicks + " clicks de los " + targetNumberOfClicks + " necesarios, y has alcanzado un nuevo record";

                PlayerPrefs.SetInt(maxScoreKey, numberOfClicks);
            }
            else
            {
                gameOverText.text = " ¡ENHORABUENA! Has conseguido " + numberOfClicks + " clicks de los " + targetNumberOfClicks + " necesarios, el record son " + maxScore;
            }
        }
        else
        {
            gameOverText.text = " No lo has conseguido. Dedicate a otra cosa crack ";
        }
    }
}