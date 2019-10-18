﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePause = false;

    public GameObject PauseMenuUI;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;

    } 

     void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePause = true;

    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level1");
    }

    public void Settings()
    {
        SceneManager.LoadScene("SettingsMenu");
    }



}
