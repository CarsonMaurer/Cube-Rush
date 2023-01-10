using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
   
    public int score = 0;

   
    public TextMeshProUGUI scoreText;

    void Start()
    {
        
    }

    public void IncrementScore()
    {
        score++;

      
        scoreText.text = "Coins: " + score + "/5";
    }
}