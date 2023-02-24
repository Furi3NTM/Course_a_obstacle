using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{

    private bool _toucher;
    private bool _finish;

    // Start is called before the first frame update
    void Start()
    {
        _toucher = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {

            if (_toucher == false)
            {
                gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
                Debug.Log("BRAVO MTFK");
                _toucher = true;
            }
        }
    }
}

    
