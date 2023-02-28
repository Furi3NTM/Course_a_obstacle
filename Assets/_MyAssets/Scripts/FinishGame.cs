using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    //Attributs
    private bool _toucher;
    private bool _finish;

    //Utiliser les méthodes de d'autre classe
    private GameManager _gameManager;
    private Player _player;


    private void Start()
    {
        _toucher = false;
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //mettre l'objet qui VA toucher pas l'objet qui EST touché
        if (collision.gameObject.tag == "Player" && _toucher == false)
        {
           
                int erreurs = _gameManager.GetPointage();
                float total = Time.time + erreurs;

                //Change la couleur du mur
                gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;

                //Afficher les informations sur mon jeu
                Debug.Log("BRAVO MTFK, ton temps est de : " + Time.time + " secondes" );
                Debug.Log("Vous avez accroché " + erreurs + " obstacles" );
                Debug.Log("Votre temps est de " + total + " secondes");

                //Arreter le joueur
                _player.StopJoueur();
                

        }
    }
}

    
