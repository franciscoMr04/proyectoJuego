using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    
    public float fuerzaDash;
    public GameObject playerPrefab;
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("x"))
        {
            dash();
        }
        
    }

    void dash()
    {
        GameObject Player = Instantiate(playerPrefab, transform.position, transform.rotation);
        Rigidbody rb = Player.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * fuerzaDash, ForceMode.VelocityChange);
    }
    
}
