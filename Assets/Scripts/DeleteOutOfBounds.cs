using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOutOfBounds : MonoBehaviour
{
    public float outerBoundX = -10;

    private void Update()
    {
        if(transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
