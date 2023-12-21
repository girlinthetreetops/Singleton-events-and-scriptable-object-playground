using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //jump
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            GameManager.gameManager.triggerGamePause();
        }
    }
}
