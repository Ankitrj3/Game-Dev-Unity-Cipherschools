using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Else : MonoBehaviour
{
    public int age;
    // Start is called before the first frame update
    void Start()
    {
        if (age < 18)
        {
            Debug.Log("You can't vote");
        }
        else
        {
            Debug.Log("You can vote");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
