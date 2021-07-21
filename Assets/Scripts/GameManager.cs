using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    public static GameManager inst;
    [SerializeField] private TextMeshProUGUI scoreText;
    public PlayerController playerController;


    void Awake()
    {
        inst = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void IncrementScore()
    {
        score++;
        CoinCollectSound.PlaySound();
        scoreText.text = "SCORE: " + score;
        if(playerController.playerSpeed <= 20)
        {
            playerController.playerSpeed += playerController.increasePlayerSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
