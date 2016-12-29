using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*I can edit these values using the Unity editor within the "Inspector" tab */
[System.Serializable] 

public class AnswerData {


    /** AnswerData class contains the answers to the Quiz Game's questions
     * 
     * The AnswerData class will not contain functions, 
     * as such both the "Start" & "Update" functions will not be used
     */

    public string AnswerText; //Holds the string of the answer eg "Yes", "No", "Apple", "The Moon" etc

                            // Since a bool only holds the value: true or false.
    public bool isCorrect; // Contains the condition, is "User's answer" correct or not
                           
}
