using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//cumbersome, can be shortened.
//consider other types of events if you absolutely need it.

public class UIManager : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject topBar;
    public GameObject pauseScreen;
    public GameObject gameOverScreen;

    private void Start()
    {
        startScreen.SetActive(true);

        GameManager.gameManager.OnGameOpened.AddListener(ActivatePauseScreen);
        GameManager.gameManager.OnGameStarted.AddListener(ActivateTopBar);
        GameManager.gameManager.OnGamePause.AddListener(ActivatePauseScreen);
        GameManager.gameManager.OnGameOver.AddListener(ActivateGameOverScreen);
    }

    public void SetUI(bool activeStartScreen, bool activeTopBar, bool activeGameOverScreen, bool activePauseScreen)
    {
        startScreen.SetActive(activeStartScreen);
        topBar.SetActive(activeTopBar);
        pauseScreen.SetActive(activePauseScreen);
        gameOverScreen.SetActive(activeGameOverScreen);
    }

    private void ActivateStartScreen(int i, int y)
    {
        SetUI(true, false, false, false);
    }

    private void ActivatePauseScreen()
    {
        SetUI(false, false, false, true);
    }

    private void ActivateTopBar()
    {
        SetUI(false, true, false, false);
    }

    private void ActivateGameOverScreen()
    {
        SetUI(false, false, true, false);
    }
}
