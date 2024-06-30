using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball: MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    public float speed;
    void Update()
    {
        float horizontalinput = Input.GetAxis("Horizontal");
        float verticallinput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalinput, 0.0f, verticallinput) * speed * Time.deltaTime;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movement,ForceMode.Impulse);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            Debug.Log("Collided with wall");
            ScoreManager.instance.AddScore(-8);
        }
    }
}