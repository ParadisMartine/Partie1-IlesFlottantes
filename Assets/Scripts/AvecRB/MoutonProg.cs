using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoutonProg : MonoBehaviour
{

    [SerializeField] private GameObject _parachute;
    [SerializeField] private GameObject _zone;

    private Rigidbody _rb;


    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (_zone.transform.CompareTag(other.transform.tag))
        {
            OuvreParachute();
        }
    }


    void OuvreParachute()
    {
        _parachute.SetActive(true);
        _rb.drag =10;
    }
}
