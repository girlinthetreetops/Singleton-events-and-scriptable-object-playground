using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    private string playerName;
    [SerializeField] private GameObject nameInputField;
    [SerializeField] private Button enterButton;
    [SerializeField] private TMP_Text displayText;

    private void Start()
    {
        enterButton.onClick.AddListener(SaveName);
    }

    private void SaveName()
    {
        playerName = nameInputField.GetComponent<TMP_InputField>().text;
        UpdateNameDisplay();
    }

    private void UpdateNameDisplay()
    {
        displayText.SetText("Name: " + playerName);
    }
}
