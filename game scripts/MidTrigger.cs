using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidTrigger : MonoBehaviour
{
    public GameObject FinishTrigger;
    public GameObject MiddleTrigger;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Dead")
        {
            FinishTrigger.SetActive(true);
            MiddleTrigger.SetActive(false);
        }
    }
}
