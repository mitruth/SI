﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseUI;
    public GameObject cameraObj;

    private void Start()
    {
        pauseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else 
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        pauseUI.SetActive(false);
        cameraObj.GetComponent<AudioListener>().enabled = true;
        Time.timeScale = 1f;
        isPaused = false;
    }

    void Pause()
    {
        pauseUI.SetActive(true);
        cameraObj.GetComponent<AudioListener>().enabled = false;
        Time.timeScale = 0f;
        isPaused = true;
    }
}
