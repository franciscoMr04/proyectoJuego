using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{
    public GameObject balaPrefab;

    public Transform canon;

    public float TimeToSpawn = 2f;

    public float fuerzaBala = 20f;

    

    // Start is called before the first frame update
    void Start()
    {
        Invoke("shoot", TimeToSpawn);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void shoot()
    {
        GameObject bala = Instantiate(balaPrefab, canon.position, canon.rotation);
        Rigidbody rb = bala.GetComponent<Rigidbody>();
        rb.AddForce(canon.forward * fuerzaBala, ForceMode.Impulse);

        bala script = bala.GetComponent<bala>();
        if (script != null)
        {
            script.speed = 0.5f;
        }

        Invoke("shoot", TimeToSpawn);



    }
    
}
