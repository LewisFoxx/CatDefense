using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemy : MonoBehaviour
{
    public Material redMaterial; // We can add this in the inspector

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            // Enemy Will be Detected 
            GetComponent<Renderer>().material = redMaterial;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
