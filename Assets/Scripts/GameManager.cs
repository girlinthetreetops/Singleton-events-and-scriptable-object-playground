using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    //Singleton Business
    public static GameManager gameManager { get; private set; }
    private void Awake()
    {
        if (gameManager != null && gameManager != null)
        {
            Destroy(this);
        } else
        {
            gameManager = this;
        }
    }

    //Main events
    public UnityEvent OnGameOpened;
    public UnityEvent OnGameStarted;
    public UnityEvent OnGamePause;
    public UnityEvent OnGameOver;
    
    public void triggerGameOpened()
    {
        OnGameOpened.Invoke();
        Debug.Log("Game opened!");
    }

    public void triggerGameStart()
    {
        OnGameStarted.Invoke();
        Debug.Log("Game Start!");
    }

    public UnityEvent gameOver;

    public void triggerGameOver()
    {
        OnGameOver.Invoke();
        Debug.Log("Game Over!");
    }

    public void triggerGamePause()
    {
        OnGamePause.Invoke();
        Debug.Log("Game Paused!");
    }

    //Scores
    public UnityEvent OnScoreChange;
    private int score = 0;

    public int GetScore()
    {
        return score;
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        OnScoreChange.Invoke();
    }

    //Inbuilt
    private void Start()
    {
        OnGameOpened.Invoke();
        Player.player.OnObstacleHit.AddListener(triggerGameOver);
    }
}
