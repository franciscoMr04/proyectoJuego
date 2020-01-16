using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PLayerMomevent : MonoBehaviour
{
    public float speed;

    public Rigidbody rb;
    public Camera cam;

    Vector3 movimiento;
    Vector3 mousePos;
    
    // Update is called once per frame
    void Update()
    {
        movimiento.x = Input.GetAxisRaw("Horizontal");
        movimiento.z = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        GameObject obj_ident = new GameObject();
        obj_ident.transform.position = mousePos;

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.x, lookDir.y) * Mathf.Rad2Deg - 90f;
        rb.rotation = Quaternion.Euler(0, angle, 0);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimiento * speed * Time.fixedDeltaTime);

       
    }
}
