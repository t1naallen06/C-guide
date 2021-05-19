using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    //create a varialbe to stores your nname 
    //create a variable to store your age
    //create a variable to store your speed
    //create a health variable
    //create a score variable
    //create a speed variable
    //variable to check if all the keys were collected
    //variable for ammo count

    // Start is called before the first frame update

    public string myName = "Tina";
    public int myAge = 40;
    public float mySpeed = 10.2f;
    public int health = 100;
    public int score = 120;
    public bool hasAllKeys;
    public int ammoCount = 100;
    public void Start()
    {

        Debug.Log("My name is" + myName + "and I am" + myAge + "years old" );
        Debug.Log("Speed: " + mySpeed);
        Debug.Log("Health: " + health);
        Debug.Log("Score: " + score);
        Debug.Log("Has All Keys: " + hasAllKeys);
        Debug.Log("Ammo Count: " + ammoCount);

   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
