using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject car;
    void Start()
    {
        car.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;   
    }
}
