using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemy : MonoBehaviour
{
    
    private Vector3 originalPosition;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            originalPosition = transform.position;
            // Enemy Will be Detected 
            
            
        }
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            // Enemy has left the detection zone
           
        }
    }
}
