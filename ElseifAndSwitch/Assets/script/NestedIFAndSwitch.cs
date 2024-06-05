using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NestedIFAndSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public int age;
    void Start()
    {
        if (age < 18)
        {
            Debug.Log("You are teenager");
        }
        else if (age >= 18)
        {
            Debug.Log("You are adult");
        }

        switch (score)
        {
            case 10:
                Debug.Log("you are having very good credit score");
                break;
            case 8:
                Debug.Log("you are having good credit score");
                break;
            case 6:
                Debug.Log("you are having average credit score");
                break;
            default:
                Debug.Log("Score is not good ");
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
