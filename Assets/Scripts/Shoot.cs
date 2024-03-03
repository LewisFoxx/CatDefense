using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Shoot : MonoBehaviour

{
    public GameObject Bullet;
    public Transform firePoint;
    public float bulletSpeed = 4;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            //Enemy will be detected, shoot a bullet
            Fire();
        }
    }

    // Update is called once per frame
    void Fire()
    {
        // Create a new bullet
        GameObject bullet = Instantiate(Bullet, firePoint.position, firePoint.rotation);

        // Add force to the bullet 
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.forward * bulletSpeed, ForceMode.Impulse);
    }
}
