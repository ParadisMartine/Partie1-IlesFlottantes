using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aigle : MonoBehaviour
{

    [SerializeField] private float _vitesse = 1f;

    private Rigidbody _rb;


    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        BougeAigle();
    }

    void BougeAigle()
    {
        //------------------------------------------Étape 1 


        _rb.velocity = Vector3.forward * -_vitesse;


        //------------------------------------------Étape 2 




    }
}
