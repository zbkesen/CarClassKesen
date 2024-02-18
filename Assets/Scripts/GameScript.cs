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
    private Car playerCar = new Car();
    [SerializeField] private GameObject emptyCar;
    [SerializeField] private TMP_InputField playerYearInput;
    [SerializeField] private TMP_InputField playerMakeInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void PlayerInputYear()
    {
        int playerYear = int.Parse(playerYearInput.text);
        playerCar.ChangeYearOfCar(playerYear);
        Debug.Log("This is the player's year: " + playerCar.GetYear());
    }

    void PlayerInputMake()
    {
        string playerMake = playerMakeInput.text;
        playerCar.ChangeMakeOfCar(playerMake);
        Debug.Log("This is the player's make: " + playerCar.GetMake());
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

    void InstantiateCar()
    {
        if (playerCar.GetYear() != null &&  playerCar.GetMake() != null)
        {
            Vector3 pos = new Vector3(0, 0, 0);
            GameObject carClone = Instantiate(emptyCar, pos, Quaternion.identity);
        }
    }
}
