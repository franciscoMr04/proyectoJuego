using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public int dano;
    public float speed;


    private void OnTriggerEnter(Collider other)
    {      
        if (other.CompareTag("enemigo"))
        {     
            Destroy(gameObject);
        }        
    }
}
