using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    void start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical); 

        rb.AddForce (movement * speed);
    }


    void OnTriggerEnter (Collider other) 
    {
        if (other.GameObject.CompareTag ("Pick Up"))
        {
            other.GameObject.SetActive (false);
        }
    }

}
