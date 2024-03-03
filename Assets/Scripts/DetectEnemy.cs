using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemy : MonoBehaviour
{
    public Material redMaterial; // We can add this in the inspector. Red 
    public Material originalMaterial; // Change in inspector to Green
    public float upwardMovement = 0.5f; //adjust how high in inspector
    private Vector3 originalPosition;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            originalPosition = transform.position;
            // Enemy Will be Detected 
            GetComponent<Renderer>().material = redMaterial;
            transform.position = new Vector3(transform.position.x, transform.position.y + upwardMovement, transform.position.z);
            
        }
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            // Enemy has left the detection zone
            GetComponent<Renderer>().material = originalMaterial;
            transform.position = originalPosition;
        }
    }
}
