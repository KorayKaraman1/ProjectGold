using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
   
    public bool menuG = true;
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    
    void Update()
    {
       
           
    }
    public void ScoreUPdate()
    {
        score++;
        scoreText.text=score.ToString();
    }
    public void TryAgain()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    

}
