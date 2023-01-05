using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectScript : MonoBehaviour
{
    
    public int score = 0;

    
    public GameObject player;

    
    public TextMeshProUGUI scoreText;

    void Start()
    {
        
        player = GameObject.FindWithTag("Player");

        
        scoreText = player.GetComponent<TextMeshProUGUI>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            
            score++;

            
            scoreText.text = "Coins: " + score;

            
            Destroy(gameObject);
        }
    }
}
