using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text gameTitle;
    [SerializeField] private Button startButton;

    private void Start()
    {
        gameTitle.SetText("Howdy!");
        startButton.onClick.AddListener(StartGame);
    }

    private void StartGame()
    {
        GameManager.gameManager.triggerGameStart();
    }

}
