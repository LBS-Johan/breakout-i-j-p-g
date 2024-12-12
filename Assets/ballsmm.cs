using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballsmm : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    public float speed = 40f;

    void Start()
    {       
        myRigidbody = GetComponent<Rigidbody2D>();

        myRigidbody.velocity = new Vector2(0, -speed);

    }

    // Update is called once per frame
    void Update()
    {

        myRigidbody.velocity = myRigidbody.velocity.normalized * speed;
        
    }
}
