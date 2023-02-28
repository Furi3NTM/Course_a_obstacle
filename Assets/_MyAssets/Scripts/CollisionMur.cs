using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionMur : MonoBehaviour
{
    //Attribut
    private GameManager _gameManager;
    private bool _toucher;


    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _toucher = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && _toucher == false) 
        {

             gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
             _gameManager.AugmenterPointage();
             _toucher=true;       
        }

        

    }



 
}
