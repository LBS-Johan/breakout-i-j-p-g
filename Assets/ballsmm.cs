using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballsmm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float speed = 4;
        myRigidbody.velocity = myRigidbody.velocity.normalized * speed;

    }
}
