//Session 2: Conditionals, Loops and Classes
//12Nov 2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session2 : MonoBehaviour {

    //Variables
    int myNumber = 2;
    public bool QuestionTime = true;
    int myVariableQuestionTime;

    string[] fruits = { "banana", "apple", "mange", "blueberry" };
    List<int> evenNumbers = new List<int>();
    int[] evenNumbersSmart = new int[10];

	// Use this for initialization
	void Start () {
        //variable name is equal to either 1 or 0 based on the value of questionTime
        myVariableQuestionTime = (QuestionTime == true) ? 1 : 0;
        Debug.Log("The value of myVariableQuestionTime is :" + myVariableQuestionTime);
        if (myNumber==2)
        {
            Debug.Log("Your number is equal to 2.");
        }else
        {
            Debug.Log("Your number is equal to 2.");
        }
		
	}













    
	
	// Update is called once per frame
	void Update () {
		
	}
}
