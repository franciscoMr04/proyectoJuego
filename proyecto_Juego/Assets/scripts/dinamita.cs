using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinamita : MonoBehaviour
{
    public float delay = 3f;
    public float radius = 5f;
    public float force = 200f;

    public GameObject ExplosionEffect;

    float contador;
    bool haExplotado;

    // Start is called before the first frame update
    void Start()
    {
        contador = delay; 
    }

    // Update is called once per frame
    void Update()
    {
        contador -= Time.deltaTime;
        if(contador <= 0 && !haExplotado)
        {
            explota();
            haExplotado = true;
        }
        
    }

    void explota()
    {
        Instantiate(ExplosionEffect, transform.position, transform.rotation);

        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach(Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if(rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius);
            }
        }


        Destroy(gameObject);

    }
}
