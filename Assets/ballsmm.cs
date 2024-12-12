using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class ballsmm : MonoBehaviour
{
    public int damage = 1;

    

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


        if (transform.position.y < -50)
        {
            transform.position = new Vector2(0, 0);
        }

    }
}
