using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class datatype : MonoBehaviour
{
    int myInt = 34;
    float myFloat = 33.4f;
    bool myBool = true;
    public string MyString;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("the int val is "+myInt);
        Debug.Log("the float val is "+myFloat);
        Debug.Log("the String val is " + MyString);
        Debug.Log("the bool val is " + myBool);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
