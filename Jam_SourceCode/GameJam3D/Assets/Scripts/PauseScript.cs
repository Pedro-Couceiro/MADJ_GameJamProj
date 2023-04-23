using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public bool isPaused;
    public GameObject pauseScreen;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;

            if(isPaused)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
            pauseScreen.SetActive(isPaused);
        }

        
    }

    public void ResumeGame()
    {
        isPaused = false;
        pauseScreen.SetActive(isPaused);
    }

    public void Restart()
    {

    }

    public void PauseMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void PauseQuit()
    {
        Application.Quit();
    }
}
