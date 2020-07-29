using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassLevel : MonoBehaviour
{
    private GameObject car;
    private GameObject passPosition;

    public void Click()
    {
        passPosition = GameObject.Find("PassPosition");
        car = GameObject.Find("Car");
        car.transform.position = passPosition.transform.position;
    }
}
