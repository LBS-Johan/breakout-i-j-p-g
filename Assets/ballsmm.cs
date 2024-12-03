using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class ballsmm : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    void Start()
    {
        float speed = 4;
       

        myRigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        float speed = 4;
        myRigidbody.velocity = myRigidbody.velocity.normalized * speed;
        
    }
}
