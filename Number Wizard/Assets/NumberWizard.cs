using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max = 1001;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to the jungle, I am the number wizard and may your mind be bamboozled!");
        Debug.Log("I want you to choose a number, A NUMBER, NOT A LETTER, WORD, SENTENCE, I WANT A NUMBER YOU HEAR ME!");
        Debug.Log("Altough I am a wizard, I'm not all seeing. The number has to be less than " + max + ".");
        Debug.Log("The number has to be greater than " + min + ".");
        Debug.Log("By the power of magic, I compel you to tell me if the number is greater or lower than " + guess + "!");
        Debug.Log("Pssst, you do this by pushing up if its higher, down if its lower., and enter if its correct.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            min = guess;
            guess = (min + max)/2;
            Debug.Log("So its lower you say [...], well then, is it greater than or less than " + guess + ".");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)){
            max = guess;
            guess = (min + max) / 2;
            Debug.Log("So its greater you say [...], well then, is it greater than or less than " + guess + ".");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("AH HA, I knew that it was the number " + guess + " all along!");
        }
    }
}
