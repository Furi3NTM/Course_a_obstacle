using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonePiege : MonoBehaviour
{
    //Attributs
    private bool _estActive = false;
    private Rigidbody _rb;
    [SerializeField] private GameObject _piege = default;
    [SerializeField] private float intensiteForce = 600;

    private void Start()
    {
        _rb = _piege.GetComponent<Rigidbody>();
        _rb.useGravity = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !_estActive)
        {
           Debug.Log("U GET CATCH MTFK");
        
            //Choisir une direction dans lequel la force est appliquer
            Vector3 directionPerso = new Vector3(0f, -1f, 0f);
            _rb.AddForce(directionPerso * intensiteForce);

            _rb.useGravity = true;
            _estActive = true;
        }
        
    }
}
