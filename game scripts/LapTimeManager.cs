using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public static int mins;
    public static int secs;
    public static float milis ;
    public static string milistring;

    public GameObject minbox;
    public GameObject secbox;
    public GameObject milibox;

    // Update is called once per frame
    void Update()
    {
        milis += Time.deltaTime * 8;
        milistring = milis.ToString("F0");
        milibox.GetComponent<Text>().text = "" + milistring;

        if (milis > 9)
        {
            milis = 0;
            secs += 1;
        }

        if (secs <= 9)
        {
            secbox.GetComponent<Text>().text = "0" + secs + ".";
        }
        else
        {
            secbox.GetComponent<Text>().text = "" + secs + ".";
        }

        if (secs >= 60)
        {
            secs = 0;
            mins += 1;
        }

        if (mins <= 9)
        {
            minbox.GetComponent<Text>().text = "0" + mins + ":";
        }
        else
        {
            minbox.GetComponent<Text>().text = "" + mins + ":";
        }




    }
}
