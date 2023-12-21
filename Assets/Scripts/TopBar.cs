using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TopBar : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    private void Start()
    {
        GameManager.gameManager.OnScoreChange.AddListener(UpdateScore);
        scoreText.SetText("Your Score is: 0");
    }

    private void UpdateScore()
    {
        int latestScore = GameManager.gameManager.GetScore();
        string textScore = latestScore.ToString();
        scoreText.SetText("Your score is: " + textScore);
    }
}
