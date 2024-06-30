using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelmanager : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform instatiatePos;

    public CameraFollowScript cameraFollow;
    void Start()
    {
        GameObject go = Instantiate(ballPrefab,instatiatePos.position,Quaternion.identity);
        cameraFollow.target = go.transform;
    }

   
}
