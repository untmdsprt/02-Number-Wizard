using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int maxnumber = 1000;
        int minnumber = 1;


        Debug.Log("Welcome to the Number Wizard!");
        Debug.Log("Please pick a number, but don't tell me what it is.");
        Debug.Log("The highest number you can pick is: " + maxnumber);
        Debug.Log("The lowest number you can pick is: " + minnumber);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push UpArrow = Higher, Push DownArrow = Lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the Return key is pressed down
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Return key was pressed.");
        }

        //Detect when the up arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {   
            Debug.Log("UpArrow key was pressed.");
        }

        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {    
            Debug.Log("DownArrow key was pressed.");
        }
    }
}
