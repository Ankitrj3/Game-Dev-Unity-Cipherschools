using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // Start is called before the first frame update
    int global = 12;
    void Start()
    {
        Debug.Log("this is the value of Global variable " + global);
        hello();
        Debug.Log(add(2, 243));
    }

    // Update is called once per frame
    void Update()
    {
        //hello;
    }
    public void hello()
    {
        Debug.Log("Hello ankit");
    }
     //this res is a local variable
    public int add(int a,int b)
    {
        int res = a + b;
        return res;
    }
}
