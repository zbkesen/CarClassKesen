using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    private Car playerCar;
    [SerializeField] private TMP_InputField playerInput;
    [SerializeField] private TMP_Text yearText;
    [SerializeField] private TMP_Text makeText;

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
        int yearInput = playerCar.Year;
        string output = "";
        yearInput = int.Parse(output);
        OnClickSubmitButton(output);
        yearText.text = output;
    }

    void PlayerInputMake()
    {
        string output = "";
        if (playerInput != null)
        {
            output = playerInput.text;
            makeText.text = output;
        }
    }

    public void OnClickSubmitButton(string input)
    {
        string textInput = input;
        string output = "";
        if (textInput != null && textInput != "")
        {
            output = textInput;
        }
    }
}
