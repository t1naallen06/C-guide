using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /// <summary>
    /// public or private referance
    /// data type (string, bools, float, int)
    /// every variable needs a name
    /// optional -- a value
    /// </summary>

    //variable for my name
    //variable for my age
    //for my location

    public string myName = "Tina";
    public string myAge = "40";
    public string myLocation = "Gypsum";
    public bool hasKey = false;
    // Start is called before the first frame update
    void Start()
    {
        myName = "John";
        Debug.Log("My name is: " + myName);
        Debug.Log("my age is:" + myAge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
