using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;

    public GameObject zigzagPanel;
    public GameObject gameOverPanel;
    public GameObject tapText;
    public TextMeshProUGUI score;
    public TextMeshProUGUI bestScoreHead;
    public TextMeshProUGUI bestScoreGO;

    private void Awake()
    {
        if(!instance) instance = this;
    }

    public void GameStart()
    {
        tapText.SetActive(false);
        zigzagPanel.GetComponent<Animator>().Play("TextUp");
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        gameOverPanel.GetComponent<Animator>().Play("GameOverPanel");
    }
    public void Repeat()
    {
        SceneManager.LoadScene(0);
    }
}
