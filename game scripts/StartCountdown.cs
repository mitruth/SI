using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCountdown : MonoBehaviour
{

    public GameObject countdwn;
    public AudioSource GetReady;
    public AudioSource GoAudio;

    public GameObject LapTimer;
    public GameObject CountdownTimer;
    public GameObject CarController;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountStart());
    }


    IEnumerator CountStart() 
    {
        yield return new WaitForSeconds(0.5f);
        countdwn.GetComponent<Text>().text = "3";
        GetReady.Play();
        countdwn.SetActive(true);
        yield return new WaitForSeconds(1);
        countdwn.SetActive(false);
        countdwn.GetComponent<Text>().text = "2";
        GetReady.Play();
        countdwn.SetActive(true);
        yield return new WaitForSeconds(1);
        countdwn.SetActive(false);
        countdwn.GetComponent<Text>().text = "1";
        GetReady.Play();
        countdwn.SetActive(true);
        yield return new WaitForSeconds(1);
        countdwn.SetActive(false);
        GoAudio.Play();
        LapTimer.SetActive(true);
        CountdownTimer.SetActive(true);
        CarController.SetActive(true);
  }

}
