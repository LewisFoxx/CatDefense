using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // This will destroy the enemy object
            Destroy(this.gameObject); // this will destroy the bullet
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
