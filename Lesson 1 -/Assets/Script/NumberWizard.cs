using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {


    // Declare 2 integer variables
    int min;
    int max;
    int guess;

    void NextGuess(){

        print("Is the number bigger or smaller than " + guess + " ?");
        print("Press UP if number is bigger");
        print("Press DOWN if number is bigger");
        print("Press ENTER if number is bigger");

    }

    void StartGame(){

        min = 1;
        max = 1001;
        guess = 500;
        // Output to the Console (Both)
        print("Welcome to Number Wizard");
        // Adding min and max to the String
        Debug.Log("Please choose a number from " + min + " to " + max);
        NextGuess();

    }


    // Use this for initialization
    void Start() {

        StartGame();

        }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {

            print("UP Pressed");
            min = guess;
            guess = (max + min) / 2;
            NextGuess();

        }

        else

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            print("DOWN Pressed");
            max = guess;
            guess = (max + min) / 2;
            NextGuess();
        }

        else

        // Return = ENTER ... Keypad Enter is only for the keypad
        if (Input.GetKeyDown(KeyCode.Return))
        {

            Debug.Log("ENTER Pressed");
            Debug.Log("Number Gussed");
            print("(P)lay again or (Q)uit");

            if (Input.GetKeyDown(KeyCode.Q))
            {

                UnityEditor.EditorApplication.isPlaying = false;

            }

            else
                if (Input.GetKeyDown(KeyCode.P))
            {
                StartGame();
            }



        }
    }
}
