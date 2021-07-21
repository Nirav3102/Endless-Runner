using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalSpeed = 10f;
    private float horizontalInput;
    private bool isAlive = true;
    public float playerSpeed = 10f;
    public float increasePlayerSpeed = 0.2f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private CharacterController controller;
    Vector3 velocity;
    [SerializeField] private float gravity = -20f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundDistance = 0.4f;
    [SerializeField] private bool isGrounded;
    private float jumpHeight = 2f;
    public GameOver gameOver;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if(!isAlive)
        {
            return;
        }

        horizontalInput = Input.GetAxis("Horizontal");

        Vector3 move = transform.right * horizontalInput * horizontalSpeed + transform.forward * playerSpeed;
        controller.Move(move * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        //Check if player is grounded
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayer);
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        if(transform.position.y < -5)
        {
            Die();
        }
    }

    void FixedUpdate()
    {

    }

    public void Die()
    {
        isAlive = false;
        //Debug.Log(GameManager.score);
        gameOver.GameOverScreen(GameManager.score);
    }
}
