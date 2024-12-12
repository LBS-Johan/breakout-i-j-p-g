using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {

        currentHealth = maxHealth;

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log($"Health: {currentHealth}");

        if (currentHealth <= 0)
        {
            Destroy(gameObject); //destroys the object if health reaches zero
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
