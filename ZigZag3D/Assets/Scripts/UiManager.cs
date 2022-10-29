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

    private void Start()
    {
        bestScoreHead.text = "Best Score: " + PlayerPrefs.GetInt("bestScore");
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
        score.text = ScoreManager.instance.score.ToString();
        bestScoreGO.text = ScoreManager.instance.bestScore.ToString();
    }
    public void Repeat()
    {
        SceneManager.LoadScene(0);
    }
}
