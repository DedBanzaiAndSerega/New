using UnityEngine;
using System.Collections;

public class DamagedByCollision : MonoBehaviour {

    // Use this for initialization
    // delete health
    int health = 1;
    void OnCollisionEnter2D()
    {
        Debug.Log("Collision!");
    }
    void OnTriggerEnter2D(Collider2D bullet)
    {
        GameObject a = bullet.gameObject;
        Destroy(a);
        health--;
        Debug.Log("Trigger!");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
