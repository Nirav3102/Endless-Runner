using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI finalScore;
    
    public void GameOverScreen(int score)
    {
        gameObject.SetActive(true);
        finalScore.text = "YOUR SCORE: " + score;
    }

    public void Restart()
    {
        GameManager.score = 0;
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
