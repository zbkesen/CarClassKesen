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


public class GameScript : MonoBehaviour
{
    [SerializeField] private TMP_InputField playerYearInput;
    [SerializeField] private TMP_InputField playerMakeInput;
    [SerializeField] private TMP_Text yearText;
    [SerializeField] private TMP_Text makeText;
    [SerializeField] private TMP_Text speedText;
    [SerializeField] private TMP_Text infoText;
    private Car playerCar;
    private int playerYear;
    private string playerMake;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpeedControl();
    }

    void PlayerInputYear()
    {
        int yearEntered = int.Parse(playerYearInput.text);
        if (yearEntered <= 2024 && yearEntered >= 1886)
        {
            playerYear = yearEntered;
            infoText.text = "";
            Debug.Log("This is the player's year: " + playerYear);
        }
        else
        {
            infoText.text = "Year must be from 1886 to 2024.";
        }
    }

    void PlayerInputMake()
    {
        playerMake = playerMakeInput.text;
        Debug.Log("This is the player's make: " + playerMake);
    }

    public void OnClickYearButton()
    {
        PlayerInputYear();
        InstantiateCar();
    }

    public void OnClickMakeButton()
    {
        PlayerInputMake();
        InstantiateCar();
    }

    void SpeedControl()
    {
        int playerSpeed = 0;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerCar.Accelerate(playerSpeed);
            speedText.text = playerCar.GetSpeed().ToString();
            Debug.Log(playerSpeed);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerCar.Decelerate(playerSpeed);
            speedText.text = playerCar.GetSpeed().ToString();
            Debug.Log(playerSpeed);
        }
    }

    void InstantiateCar()
    {
        if (playerYear != null &&  playerMake != null)
        {
            playerCar = new Car();
            playerCar.ChangeYearOfCar(playerYear);
            playerCar.ChangeMakeOfCar(playerMake);
            yearText.text = ($"Year: {playerCar.GetYear().ToString()}");
            makeText.text = ($"Make: {playerCar.GetMake()}");
        }
    }
}
