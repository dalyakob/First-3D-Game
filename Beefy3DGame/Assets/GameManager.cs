using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] bool IsGameOver;
    [SerializeField] GameObject gameOverScreen;
    public void EndGame()
    {
        gameOverScreen.SetActive(true);
        Invoke("TogglePause", 2);
    } 
    public void TogglePause()
    {
        if(Time.timeScale == 0)
        { 
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0f;
        }
    }
    
}
