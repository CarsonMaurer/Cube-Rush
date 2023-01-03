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

    public GameObject PlayerObject;
    public TextMeshProUGUI GameOverText;
    
    public Button Startbutton;
    public GameObject Placeholder_Hide_Start;
    public Button RestartButton;
    public TextMeshProUGUI YouWonText;
    public Button PlayAgainButton;
   

    // Start is called before the first frame update
    void Start()
    {
        PlayerObject.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        Startbutton.gameObject.SetActive(false);
        PlayerObject.gameObject.SetActive(true);

        
        IsGameActive = true;
        
        
        

    }



    
   
        
    
    public void GameOver()
    {
        Debug.Log("Game Over");
        IsGameActive = false;
        GameOverText.gameObject.SetActive(true);
        RestartButton.gameObject.SetActive(true);
    }
    public void Win()
    {
        IsGameActive = false;
        YouWonText.gameObject.SetActive(true);
        PlayAgainButton.gameObject.SetActive(true);

            
            
    }
        
    public void RestartGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Placeholder_Hide_Start.gameObject.SetActive(false);
       

    }
}