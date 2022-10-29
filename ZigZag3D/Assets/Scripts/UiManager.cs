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
    public TextMeshProUGUI scoreInGame;
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

    private void Update()
    {
        scoreInGame.text = ScoreManager.instance.score.ToString();
    }

    public void GameStart()
    {
        zigzagPanel.GetComponent<Animator>().Play("TextUp");
        tapText.GetComponent<Animator>().Play("textDown");
        scoreInGame.GetComponent<Animator>().Play("ScoreDown");
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        gameOverPanel.GetComponent<Animator>().Play("GameOverPanel");
        scoreInGame.GetComponent<Animator>().Play("ScoreUp");
        score.text = ScoreManager.instance.score.ToString();
        bestScoreGO.text = ScoreManager.instance.bestScore.ToString();
    }
    public void Repeat()
    {
        SceneManager.LoadScene(0);
    }
}
