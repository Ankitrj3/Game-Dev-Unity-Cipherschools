using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    // Start is called before the first frame update
    List<string> myList = new List<string>();
    void Start()
    {
        myList.Add("ankit");
        myList.Add("Ranjan");
        myList.Add("Sumit");
        myList.Add("Dinesh");

        for(int i = 0; i < myList.Count; i++)
        {
            Debug.Log(myList[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
