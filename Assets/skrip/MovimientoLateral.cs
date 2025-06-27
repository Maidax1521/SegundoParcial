using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoLateral : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float velocidad = 5f;
    private Rigidbody2D rb;
    private Vector2 movimiento;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        movimiento = new Vector2(horizontal, vertical).normalized;    
    }

    [System.Obsolete]
    private void FixedUpdate()
    {
        rb.velocity = movimiento * velocidad;
    }
}
