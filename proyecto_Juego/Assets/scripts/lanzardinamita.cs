using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanzardinamita : MonoBehaviour
{
    public float fuerzaLanzaminento = 40f;
    public GameObject dinamitaPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("x"))
        {
            lanzarDinamita();
        }
    }

    void lanzarDinamita()
    {
        GameObject Dinamita = Instantiate(dinamitaPrefab, transform.position, transform.rotation);
        Rigidbody rb = Dinamita.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * fuerzaLanzaminento, ForceMode.VelocityChange);
    }
}
