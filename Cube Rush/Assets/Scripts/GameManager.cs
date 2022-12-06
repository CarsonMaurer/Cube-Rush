using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool IsGameActive = false;
    public List<GameObject> Target;

    
    public TextMeshProUGUI GameOverText;
     public TextMeshProUGUI GametitleText;
    public Button Startbutton;
    
    public Button RestartButton;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame()
    {
        GametitleText.gameObject.SetActive(false);
        Startbutton.gameObject.SetActive(false);

        
        IsGameActive = true;
        
        
        

    }



    
   
        
    
    public void GameOver()
    {
        IsGameActive = false;
        GameOverText.gameObject.SetActive(true);
        RestartButton.gameObject.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}