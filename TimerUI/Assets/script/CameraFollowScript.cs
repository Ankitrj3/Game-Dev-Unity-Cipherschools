using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public Vector3 offset;

    private void Update()
    {
        //position of camera = position of target + offset
        transform.position = target.position + offset;
    }
}


