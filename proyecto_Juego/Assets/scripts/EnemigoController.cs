using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoController : MonoBehaviour
{
    public Transform target;

    float visionRange = 20f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            float dist = Vector3.Distance(transform.position, target.position);

            if (dist <= visionRange)
            {
                transform.LookAt(target);
            }
            else
            {
                resetRotation();
            }
        }
        else
        {
            resetRotation();
        }

    }

    void resetRotation()
    {
        Quaternion LerpedRotation =
            Quaternion.Lerp(transform.rotation, Quaternion.Euler(Vector3.zero), 0.02f);

        transform.rotation = LerpedRotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bala"))
        {
            Destroy(gameObject);
        }
    }

}
