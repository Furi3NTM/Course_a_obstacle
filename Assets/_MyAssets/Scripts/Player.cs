using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Attributs 
    [SerializeField] private float _vitesse = 800;
    private bool _estActif = true;                     //??
    private Rigidbody _rb;


    // Méthodes privées
   private void Start()
    {
        //Position de depart du joueur
        transform.position = new Vector3(-43.1f, 0.51f, -44.59f);
        _rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        if (_estActif)
        {
         MouvementsJoueur();
        }
   
    }
    

    private void MouvementsJoueur()
    {
       float positionX = Input.GetAxis("Horizontal");
       float positionZ = Input.GetAxis("Vertical");
       Vector3 direction = new Vector3(positionX, 0f, positionZ);
       //transform.Translate(direction * Time.deltaTime * _vitesse);
       _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;
    }

    public void StopJoueur()
    {
        this.gameObject.SetActive(false);
    }
   
}
