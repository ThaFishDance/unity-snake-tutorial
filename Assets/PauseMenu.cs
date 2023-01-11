using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
  public static bool GameIsPaused = false;
  public GameObject pauseMenuUI;

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Escape))
    {
      if (GameIsPaused)
      {
        Resume();
      }
      else
      {
        Pause();
      }
    }
  }

  public void Pause()
  {
    Debug.Log("Game is paused");
    pauseMenuUI.SetActive(true);
    Time.timeScale = 0f;
    GameIsPaused = true;
  }

  public void Resume()
  {
    Debug.Log("Game is resumed");
    pauseMenuUI.SetActive(false);
    Time.timeScale = 1f;
    GameIsPaused = false;
  }

  public void LoadMenu()
  {
    Time.timeScale = 1f;
    Debug.Log("Loading menu");
    SceneManager.LoadScene("MainMenu");
  }

  public void QuitGame()
  {
    Debug.Log("Quitting game");
    Application.Quit();
  }
}
