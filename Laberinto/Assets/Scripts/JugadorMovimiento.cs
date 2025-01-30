using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorMovimiento : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody rb;
    private Vector3 direccionMovimiento;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void Update()
    {
        float movX = Input.GetAxis("Horizontal"); // Movimiento en X (A-D o Flechas)
        float movZ = Input.GetAxis("Vertical");   // Movimiento en Z (W-S o Flechas)

        direccionMovimiento = new Vector3(movX, 0, movZ).normalized;
    }

    void FixedUpdate()
    {
        Vector3 nuevaPosicion = rb.position + direccionMovimiento * velocidad * Time.fixedDeltaTime;
        rb.MovePosition(nuevaPosicion);
    }


}

