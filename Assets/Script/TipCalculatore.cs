using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculatore : MonoBehaviour
{
    //bill is 40
    //tip is 20% or based on what the user wants
    //calculate total amount

    public int bill = 40;
    public float tip = 20.0f;
    public float totalAmount;

    // Start is called before the first frame update
    void Start()
    {
        float tipAmount = bill * (tip / 100);
        totalAmount = bill + tipAmount;

        Debug.Log("Your bill is:" + bill + "and you tip amount is:" + tipAmount + "So you owe:" + totalAmount);
            //your bill is: and your tip amount is: so you owe: totalAmount
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
