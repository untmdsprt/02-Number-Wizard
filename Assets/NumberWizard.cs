using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maxNumber;
    int minNumber;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        maxNumber = 1000;
        minNumber = 1;
        guess = 500;

        Debug.Log("Welcome to the Number Wizard!");
        Debug.Log("Please pick a number, but don't tell me what it is.");
        Debug.Log("The highest number you can pick is: " + maxNumber);
        Debug.Log("The lowest number you can pick is: " + minNumber);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push UpArrow = Higher, Push DownArrow = Lower, Push Enter = Correct");
        maxNumber += 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {   
            minNumber = guess;
            NextGuess();
        }
        
        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {    
            maxNumber = guess;
            NextGuess();
        }
        
        //Detect when the Return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Correct!!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (maxNumber + minNumber) / 2;
        Debug.Log("Is it higher or lower than..." + guess);
    }
}
