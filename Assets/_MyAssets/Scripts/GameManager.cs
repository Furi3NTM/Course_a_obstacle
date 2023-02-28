using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //Attributs
    private int _pointage;


    private void Start()
    {
        _pointage = 0;
        Instruction();
    }


    //Méthodes
    private static void Instruction()
    {
        Debug.Log("*** Course a obstacle ***");
        Debug.Log("*** Atteindre la fin du parcours le plus rapidement possible ***");
        Debug.Log("*** Chaque obstacle touché entraine une pénalitée ***");
    }

    public void AugmenterPointage()
    {
        _pointage++;
        Debug.Log("Le pointage est de " + _pointage);
    }

    public int GetPointage()
    {
        return _pointage;
    }
}
