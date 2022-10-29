using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool gameOver;
    public bool startGame;

    private void Awake()
    {
        if(!instance) instance = this;
    }
    private void Start()
    {
        gameOver = false;
        startGame = false;
    }

    public void StartGame()
    {
        startGame = true;
        UiManager.instance.GameStart();
        ScoreManager.instance.StartIncrementScore();
    }

    public void GameOver()
    {
        gameOver = true;
        UiManager.instance.GameOver();
        ScoreManager.instance.StopIncrementScore();
    }
}
