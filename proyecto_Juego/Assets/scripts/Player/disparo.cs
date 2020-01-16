using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public Transform firePoint;
    public GameObject balaPrefab;

    public float fuerzaBala = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
    }

    void shoot()
    {
        GameObject bala = Instantiate(balaPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bala.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.forward * fuerzaBala, ForceMode.Impulse); 
    }
}
