using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject pauseUI;
    public GameObject cameraObj;

    public void ResumeGame()
    {
        pauseUI.SetActive(false);
        cameraObj.GetComponent<AudioListener>().enabled = true;
        Time.timeScale = 1f;
        PauseMenu.isPaused = false;
    }
}
