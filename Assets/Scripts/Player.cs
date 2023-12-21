using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    //Singleton Business
    public static Player player { get; private set; }
    private void Awake()
    {
        if (player != null && player != null)
        {
            Destroy(this);
        }
        else
        {
            player = this;
        }
    }

    private Rigidbody rb;
    [SerializeField] private AudioClip jump;

    private bool isGrounded = true;
    [SerializeField] private float jumpForce = 12f;

    public UnityEvent OnObstacleHit;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        AudioManager.Intance.PlaySound(jump);
        isGrounded = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) {
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            OnObstacleHit.Invoke();
        }
        
    }


}
