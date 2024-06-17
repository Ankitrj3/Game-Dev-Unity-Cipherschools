using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelmanager : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform instatiatePos;
    void Start()
    {
        Instantiate(ballPrefab,instatiatePos.position,Quaternion.identity);
    }

   
}
