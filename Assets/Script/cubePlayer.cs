using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubePlayer : MonoBehaviour
{ 
     //create a program that when you hit the space key, you increment a score value.
     //when the score value is greater than 50 you turn the cube Green.
     //at the start of the program turn the cube red.

    public GameObject cube;
    public int score = 0;
    private Renderer _renderer;
    
    void Start()
    {

        _renderer  = cube.GetComponent <Renderer>();
        _renderer.material.SetColor("_Color", Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score = score + 5;
            if (score > 50)
            {
                _renderer.material.SetColor("_Color", Color.green);
            }
        }




    }
}
