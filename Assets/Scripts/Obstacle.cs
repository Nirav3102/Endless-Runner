using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{ 
    PlayerController playerController;
    public static bool stopCamera = false;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindObjectOfType<PlayerController>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            CollisionSound.PlaySound();
            //kill the player
            playerController.Die();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
