using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

//////////////////////////////////////////////
//Assignment/Lab/Project: Car Class
//Name: Zarek Kesen
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 2/18/2024
/////////////////////////////////////////////

public class Car : MonoBehaviour
{
    private int year;
    private string make;
    private int maxSpeed = 100;
    private int currentSpeed = 0;
    [SerializeField] private TMP_Text yearText;
    [SerializeField] private TMP_Text makeText;
    [SerializeField] private TMP_Text speedText;

    void Start()
    {

    }

    public void ChangeYearOfCar(int newYear)
    {
        if (newYear <= 2024 && newYear >= 1886)
        {
            year = newYear;
        }
    }

    public int GetYear()
    {
        return year;
    }

    public void ChangeMakeOfCar(string newMake)
    {
        if (newMake == "" || newMake == null)
        {
            return;
        }
        else
        {
            make = newMake;
        }
    }

    public string GetMake()
    {
        return make;
    }

    public void Accelerate()
    {
        if (currentSpeed < maxSpeed)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                currentSpeed++;
            }
        }
    }
    public void Decelerate()
    {
        if (currentSpeed >= 0 && currentSpeed <= maxSpeed)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                currentSpeed--;
            }
        }
    }
}
