using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
  public static bool GameIsPaused = false;
  public GameObject pauseMenuUI;

  void Update()
  {
    if (Input.GetButtonDown(KeyCode.Escape.ToString()))
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

  private void Pause()
  {
    Debug.Log("Game is paused");
    pauseMenuUI.SetActive(true);
    Time.timeScale = 0f;
    GameIsPaused = true;
  }

  private void Resume()
  {
    Debug.Log("Game is resumed");
    pauseMenuUI.SetActive(false);
    Time.timeScale = 1f;
    GameIsPaused = false;
  }
}
