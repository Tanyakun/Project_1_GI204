﻿using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false; // statusGame

    public void TagglePause() // Game OnClick
    {
        if (isPaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0; // PauseGame
        isPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1; // PlayGame
        isPaused = false;
    }
}