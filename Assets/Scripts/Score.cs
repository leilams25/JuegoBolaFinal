using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;  
    public TextMeshProUGUI scoreText;  

    
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

  
    private void UpdateScoreText()
    {
        scoreText.text = "Puntos: " + score.ToString();
    }
}
