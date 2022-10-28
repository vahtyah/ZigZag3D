using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool gameOver;

    private void Awake()
    {
        if(!instance) instance = this;
    }
    private void Start()
    {
        gameOver = false;
    }

    public void StartGame()
    {
        UiManager.instance.GameStart();
    }

    public void GameOver()
    {
        UiManager.instance.GameOver();
    }
}
