using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{

    public GameObject lapcompletetrig;
    public GameObject halflaptrig;

    public GameObject minbox;
    public GameObject secbox;
    public GameObject milibox;

    public GameObject lapcounter;

    private int lastsec, lastmin;
    private float lastmili;

    private int count = 0;
    public static int lapcount = 1;

    public static bool gameWon = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Dead")
        {
            if (lapcount == 3 && !Countdown.endgame)
            {
                gameWon = true;
                SceneManager.LoadScene(4);
            }

            count += 1;
            lapcount += 1;

            lapcounter.GetComponent<Text>().text = "" + lapcount + "/3";


            if (count == 1)
            {
                if (LapTimeManager.secs <= 9)
                {
                    secbox.GetComponent<Text>().text = "0" + LapTimeManager.secs + ".";
                    lastsec = LapTimeManager.secs;
                }
                else
                {
                    secbox.GetComponent<Text>().text = "" + LapTimeManager.secs + ".";
                    lastsec = LapTimeManager.secs;
                }

                if (LapTimeManager.mins <= 9)
                {
                    minbox.GetComponent<Text>().text = "0" + LapTimeManager.mins + ".:";
                    lastmin = LapTimeManager.mins;
                }
                else
                {
                    minbox.GetComponent<Text>().text = "" + LapTimeManager.mins + ":";
                    lastmin = LapTimeManager.mins;
                }

                milibox.GetComponent<Text>().text = "" + LapTimeManager.milis;
                lastmili = LapTimeManager.milis;

                LapTimeManager.mins = 0;
                LapTimeManager.secs = 0;
                LapTimeManager.milis = 0;
            }
            else
            {
                if (lastmin > LapTimeManager.mins)
                {
                    if (LapTimeManager.secs <= 9)
                    {
                        secbox.GetComponent<Text>().text = "0" + LapTimeManager.secs + ".";
                        lastsec = LapTimeManager.secs;
                    }
                    else
                    {
                        secbox.GetComponent<Text>().text = "" + LapTimeManager.secs + ".";
                        lastsec = LapTimeManager.secs;
                    }

                    if (LapTimeManager.mins <= 9)
                    {
                        minbox.GetComponent<Text>().text = "0" + LapTimeManager.mins + ".:";
                        lastmin = LapTimeManager.mins;
                    }
                    else
                    {
                        minbox.GetComponent<Text>().text = "" + LapTimeManager.mins + ":";
                        lastmin = LapTimeManager.mins;
                    }

                    milibox.GetComponent<Text>().text = "" + LapTimeManager.milis;
                    lastmili = LapTimeManager.milis;
                }


                if (lastmin == LapTimeManager.mins && lastsec > LapTimeManager.secs)
                {
                    if (LapTimeManager.secs <= 9)
                    {
                        secbox.GetComponent<Text>().text = "0" + LapTimeManager.secs + ".";
                        lastsec = LapTimeManager.secs;
                    }
                    else
                    {
                        secbox.GetComponent<Text>().text = "" + LapTimeManager.secs + ".";
                        lastsec = LapTimeManager.secs;
                    }

                    if (LapTimeManager.mins <= 9)
                    {
                        minbox.GetComponent<Text>().text = "0" + LapTimeManager.mins + ".:";
                        lastmin = LapTimeManager.mins;
                    }
                    else
                    {
                        minbox.GetComponent<Text>().text = "" + LapTimeManager.mins + ":";
                        lastmin = LapTimeManager.mins;
                    }

                    milibox.GetComponent<Text>().text = "" + LapTimeManager.milis;
                    lastmili = LapTimeManager.milis;
                }



                if (lastmin == LapTimeManager.mins && lastsec == LapTimeManager.secs && lastmili > LapTimeManager.milis)
                {
                    if (LapTimeManager.secs <= 9)
                    {
                        secbox.GetComponent<Text>().text = "0" + LapTimeManager.secs + ".";
                        lastsec = LapTimeManager.secs;
                    }
                    else
                    {
                        secbox.GetComponent<Text>().text = "" + LapTimeManager.secs + ".";
                        lastsec = LapTimeManager.secs;
                    }

                    if (LapTimeManager.mins <= 9)
                    {
                        minbox.GetComponent<Text>().text = "0" + LapTimeManager.mins + ".:";
                        lastmin = LapTimeManager.mins;
                    }
                    else
                    {
                        minbox.GetComponent<Text>().text = "" + LapTimeManager.mins + ":";
                        lastmin = LapTimeManager.mins;
                    }

                    milibox.GetComponent<Text>().text = "" + LapTimeManager.milis;
                    lastmili = LapTimeManager.milis;

                }

                LapTimeManager.mins = 0;
                LapTimeManager.secs = 0;
                LapTimeManager.milis = 0;
            }

            halflaptrig.SetActive(true);
            lapcompletetrig.SetActive(false);
        }
    }
}
