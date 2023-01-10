using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectScript : MonoBehaviour
{
    
    public ScoreManager scoreManager;

    public GameObject player;


    void Start()
    {
       
        scoreManager = FindObjectOfType<ScoreManager>();
        player = GameObject.FindWithTag("Player");

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            
            scoreManager.IncrementScore();

            
            Destroy(gameObject);
        }
    }
}






