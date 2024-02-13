using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Taureau : MonoBehaviour
{
    private Rigidbody _rb;
    
    // Start is called before the first frame updat
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void Bouge()
    {

    }


    void OnCollisionEnter(Collision collision)
    {   
     
    }
}
