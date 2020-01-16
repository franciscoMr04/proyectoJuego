using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public int dano = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //other.GetComponent<PLayerMomevent>().vida -= dano;
            //Debug.Log(other.GetComponent<PLayerMomevent>().vida);

            Destroy(gameObject);
        }

        if (other.CompareTag("enemigo"))
        {
            //other.GetComponent<PLayerMomevent>().vida -= dano;
            //Debug.Log(other.GetComponent<PLayerMomevent>().vida);

            Destroy(gameObject);
        }
    }
}
