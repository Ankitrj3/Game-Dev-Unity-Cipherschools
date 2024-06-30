using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesManager : MonoBehaviour
{
    // Start is called before the first frame update
    int childCount = 0;
    public bool allCoinsCollected = false;
    private void Start()
    {
        childCount = transform.childCount;

    }
    private void Update()
    {
        if (transform.childCount < childCount)
        {
            Debug.Log("Child object is destroyed");

            childCount = transform.childCount;

            if (childCount == 0)
            {
                allCoinsCollected = true;
            }
        }
    }
}
