using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLapCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LapCounterContainer;

    void Start()
    {
        LapCounterContainer.GetComponent<LapTimeManager>().enabled = true;
    }
}
