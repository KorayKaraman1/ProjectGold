using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MaimMenuContoller : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void TapToStart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void ExitButton()
    {
        
        Application.Quit();
    }
}
