using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouton : MonoBehaviour
{

    [SerializeField] private GameObject _parachute;
    [SerializeField] private GameObject _zone;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == _zone.transform.tag)
        {
            OuvreParachute();
        }
    }


    void OuvreParachute()
    {
        _parachute.SetActive(true);
    }
}
