using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIncreaseScore : MonoBehaviour
{
    // Start is called before the first frame update

    //declare variable to hold score


    [SerializeField]
     private int _score = 0;

    //hasSaidMessage variable

    [SerializeField]
    private bool _hasMessageBeenSent = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if the spacebar is pushed
        //then 10 points will be added to my score

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _score = _score + 10;
            Debug.Log(_score);

        }

        //if point are greater than or equal to 50 AND && hasSaidMessage is false
        //then print our you are awesome!

        if(_score >= 50 && _hasMessageBeenSent == false)
        {
            Debug.Log("You are awesome");
            _hasMessageBeenSent = true;
        }

    }
}
