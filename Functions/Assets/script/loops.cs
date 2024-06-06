using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //for loop
        /* for(int i = 0; i <= 10; i++)
            {
                Debug.Log("the value of i is " + i);
            }  */

        //while loop
        //int i = 0;
        //while (i <= 0)
        //{
        //    Debug.Log(i);
        //}

        //do - while loop

        int i = 1;
        do
        {
            Debug.Log(i);
            i++;
        } while (i <= 10);


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
