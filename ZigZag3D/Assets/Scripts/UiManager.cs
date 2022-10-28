using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public GameObject zigzagPanel;
    public GameObject gameOverPanel;
    public GameObject tapText;
    public TextMeshProUGUI score;
    public TextMeshProUGUI bestScoreHead;
    public TextMeshProUGUI bestScoreGO;

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
}
