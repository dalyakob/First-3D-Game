using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] bool IsGameOver = false;
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] GameObject levelCompleteScreen;
    [SerializeField] GameObject pauseGameScreen;
    [SerializeField] PlayerMovement playerMovement;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }
    public void EndGame()
    {
        IsGameOver = true;
        playerMovement.enabled = false;
        gameOverScreen.SetActive(true); 
    } 

    public void LevelCompleted()
    {
        if (!IsGameOver)
        {
            levelCompleteScreen.SetActive(true); 
        }
    }

    public void TogglePause()
    {
        if(Time.timeScale == 0)
        {
            pauseGameScreen.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            pauseGameScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    
}
