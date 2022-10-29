using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score;
    public int bestScore;

    private void Awake()
    {
        if(!instance) instance = this; 
    }
    private void Start()
    {
        score = 0;
        PlayerPrefs.SetInt("score", score);
        bestScore = PlayerPrefs.GetInt("bestScore");
    }

    public void IncrementScoreTrigerDiamond(int value = 2)
    {
        score += value;
    }

    void IncrementScore()
    {
        score++;
    }

    public void StartIncrementScore()
    {
        InvokeRepeating("IncrementScore", 1f, .5f);
    }

    public void StopIncrementScore()
    {
        CancelInvoke("IncrementScore");
        PlayerPrefs.SetInt("score", score);
        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt("bestScore", bestScore);
        }
    }
}
