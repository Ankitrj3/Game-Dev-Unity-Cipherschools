using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour
{
    // Start is called before the first frame update
    public int [] Myarray = new int[5];
    void Start()
    {
        for(int i =0; i<Myarray.Length; i++)
        {
            Debug.Log("my array value is "+ Myarray[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
