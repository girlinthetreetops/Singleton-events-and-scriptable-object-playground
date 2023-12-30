using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGameButton : MonoBehaviour
{
    private Button startButton;

    private void Start()
    {
        startButton = GetComponent<Button>();
        startButton.onClick.AddListener(StartGame);
    }

    private void StartGame()
    {
        GameManager.gameManager.triggerGameStart();
    }

}
