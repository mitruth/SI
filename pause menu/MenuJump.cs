using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuJump : MonoBehaviour
{
    //public GameObject loseUI;
   // public GameObject cameraObj;
    // Start is called before the first frame update
    public void MainMenu()
    {
        LapTimeManager.mins = 0;
        LapTimeManager.secs = 0;
        LapTimeManager.milis = 0;
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
