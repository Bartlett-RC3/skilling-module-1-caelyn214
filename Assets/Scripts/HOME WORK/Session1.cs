using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Where code lives
public class Homework_Session1 : MonoBehaviour
{
   
    public int homeWorkInteger= 11; 
    float homeWorkFloat = 7.7f;

    //Text
    public string homeWorkString = "I will fininsh my homework today.";

    //Logical variable
    bool myFirstBoolean = true;

    // Data structures
    // Scope -- Type -- Values

    // 3.a.Arrays
    public int[] myintegrerArray = { 1, 2, 3, 4, 5 };
    public float[] myFloatArray = new float[5];

    // 3.b.Lists
    public List<int> myIntegerList = new List<int>();

    // 2.Fuctions
    //Scope -- Type -- Variables -- Body (Instructions)

    // Use this for initialization
    void Start()
    {
        Debug.Log("Addtion of 5 and 3 is:" + AddtionOfNumbers(5, 3));
        myFloatArray[2] = 3.2f;
        myFloatArray[3] = 5.6f;
        myFloatArray[4] = 9.2f;

        myIntegerList.Add(1);
        myIntegerList.Add(2);
        myIntegerList.Add(3);

        myIntegerList.Remove(0);
        declareVariable();
    }

    void declareVariable()
    {
        Debug.Log("My integer is " + homeWorkInteger);
        Debug.Log("My float is " + homeWorkFloat);
        Debug.Log("My string is " + homeWorkString);
    }
    int AddtionOfNumbers(int number1, int number2)
    {
        int addtionaResult = number1 + number2;
        return addtionaResult;
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello world");

    }
}
