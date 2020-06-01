using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    private Vector3 InitialPosition;
    private void Start()
    {
        InitialPosition = gameObject.transform.position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            LapTimeManager.mins = 0;
            LapTimeManager.secs = 0;
            LapTimeManager.milis = 0;
        }
    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Dead")
        {
            gameObject.transform.position = InitialPosition;
        }    
    }
}
