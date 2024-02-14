using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private int year;
    private string make;
    private int maxSpeed = 100; 
    private int currentSpeed;

    public int Year
    {
        get
        {
            return year;
        }
        set
        {
            year = value;
        }
    }

    public string Make
    {
        get
        {
            return make;
        }
        set
        {
            make = value;
        }
    }

    public void Accelerate()
    {
        if (currentSpeed < maxSpeed)
        {
            currentSpeed++;
        }
    }
    public void Decelerate()
    {
        if (currentSpeed > 0 &&  currentSpeed < maxSpeed)
        {
            currentSpeed--;
        }
    }
}
