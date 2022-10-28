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
    }

    public void IncrementScore()
    {
        score++;
    }


}
