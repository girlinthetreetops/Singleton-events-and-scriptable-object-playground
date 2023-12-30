using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //send signal to player to trigger jump, instead of letting player pick this up
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            GameManager.gameManager.triggerGamePause();
        }
    }
}
