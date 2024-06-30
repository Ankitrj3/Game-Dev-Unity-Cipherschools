//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CameraFollowScript : MonoBehaviour
//{
//    // Start is called before the first frame update
//    public Transform target;
//    public Vector3 offset;

//    private void Update()
//    {
//        //position of camera = position of target + offset
//        transform.position = target.position + offset;
//    }
//}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    // The target that the camera will follow
    public Transform target;

    // Offset between the camera and the target
    public Vector3 offset;

    // Called after all Update functions have been called
    private void LateUpdate()
    {
        // Ensure the target is assigned
        if (target != null)
        {
            // Set the camera position to the target position plus the offset
            transform.position = target.position + offset;
        }
    }
}
