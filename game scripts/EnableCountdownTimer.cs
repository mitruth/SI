using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableCountdownTimer : MonoBehaviour
{

    public GameObject CountdownTimerContainer;
    // Start is called before the first frame update
    void Start()
    {
        CountdownTimerContainer.GetComponent<Countdown>().enabled = true;
    }


}
