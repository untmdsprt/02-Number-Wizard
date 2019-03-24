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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
