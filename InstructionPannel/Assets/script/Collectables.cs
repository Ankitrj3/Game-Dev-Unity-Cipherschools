using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //Addscore
            ScoreManager.instance.AddScore(8);
            Invoke("DestroyCollectables",0.2f);
            Debug.Log("ball collided with coin");
            
        }
    }

    void DestroyCollectables()
    {
        Destroy(this.gameObject);
    }
}
