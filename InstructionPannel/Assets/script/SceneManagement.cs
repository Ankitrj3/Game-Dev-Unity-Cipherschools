using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagement: MonoBehaviour
{
    public static SceneManagement instance;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
