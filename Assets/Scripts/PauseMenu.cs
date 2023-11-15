using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject menuUI;
    public GameObject PauseButton;
    public GameObject ResumeButton;
    public GameObject RestartButton;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        isPaused = false;
        Debug.Log("Game Restarting");
    }

    public void Resume(){
        menuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        PauseButton.SetActive(true);
        ResumeButton.SetActive(false);
    }

    public void Pause(){
        menuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        PauseButton.SetActive(false);
        ResumeButton.SetActive(true);
    }

    public void Quit(){
        Application.Quit();
    }
}
