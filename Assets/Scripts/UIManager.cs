using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject topBar;
    public GameObject pauseScreen;
    public GameObject gameOverScreen;

    private void Start()
    {
        startScreen.SetActive(true);

        GameManager.gameManager.OnGameOpened.AddListener(ActivateStartScreen);
        GameManager.gameManager.OnGameStarted.AddListener(ActivateTopBar);
        GameManager.gameManager.OnGamePause.AddListener(ActivatePauseScreen);
        GameManager.gameManager.OnGameOver.AddListener(ActivateGameOverScreen);
    }

    private void ActivateStartScreen()
    {
        startScreen.SetActive(true);
        topBar.SetActive(false);
        pauseScreen.SetActive(false);
        gameOverScreen.SetActive(false);
    }

    private void ActivatePauseScreen()
    {
        startScreen.SetActive(false);
        topBar.SetActive(false);
        pauseScreen.SetActive(true);
        gameOverScreen.SetActive(false);
    }

    private void ActivateTopBar()
    {
        startScreen.SetActive(false);
        topBar.SetActive(true);
        pauseScreen.SetActive(false);
        gameOverScreen.SetActive(false);
    }

    private void ActivateGameOverScreen()
    {
        startScreen.SetActive(false);
        topBar.SetActive(false);
        pauseScreen.SetActive(false);
        gameOverScreen.SetActive(true);
    }
}
