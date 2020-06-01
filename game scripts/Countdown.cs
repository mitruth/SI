using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    private int minutes, seconds;
    public Text timerText;
    public int Minutes, Seconds;
    public static bool endgame = false;

    // Start is called before the first frame update
    void Start()
    {
        endgame = false;
        minutes = Minutes;
        seconds = Seconds;
        writeTimer(minutes, seconds);
        Invoke("updateTimer", 1f);
    }

    private void updateTimer()
    {
        seconds--;
        if (seconds < 0)
        {
            if(minutes == 0)
            {
                endgame = true;
                SceneManager.LoadScene(5);
            }
            else
            {
                minutes--;
                seconds = 59;
            }
        }
        writeTimer(minutes, seconds);
        Invoke("updateTimer", 1f);
    }

    private void writeTimer(int minutes, int seconds)
    {
        if(seconds < 10)
        {
            timerText.text = minutes.ToString() + ":0" + seconds.ToString();
        }
        else
        {
            timerText.text = minutes.ToString() + ":" + seconds.ToString();
        }
    }
}
