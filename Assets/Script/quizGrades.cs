using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quizGrades : MonoBehaviour
{
    //5 qiz grades
    //calculatethe average quiz grade
    //that prints out the grade average based on this scenario

    //print A = > 90
    //print B = > 80 < 90
    //print C = > 70 < 80
    //print F < 70 

    
    public float quiz1, quiz2, quiz3, quiz4, quiz5;
    public float average;


   
    // Start is called before the first frame update
    void Start()
    {
       quiz1 = Random.Range (1, 101);
       quiz2 = Random.Range (1, 101);
       quiz3 = Random.Range (1, 101);
       quiz4 = Random.Range (1, 101);
       quiz5 = Random.Range (1, 101);

        average = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;

        
        

        if (average >= 90)
        {
            Debug.Log("Your grade is an A");
        }
        
        else if (average >= 80 && average < 90 )
        {
            Debug.Log("Your grade is a B");
        }

        else if (average >= 70 && average < 80 )
        {
            Debug.Log("Your grade is a C");
        }

        else
        {
            Debug.Log("Your grsde is an F");
        }
    }

    // Update is called once per frame
    void Update()
    {

       
    }
}
