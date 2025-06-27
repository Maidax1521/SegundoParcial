using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour {

    private Rigidbody2D rb2D;

    [Header("Movimiento")]

    private float movimientoHorizontal = 0f;

    [SerializeField] private float velocidadDeMovimiento;

    [SerializeField] private float suavizadoDeMovimiento;

    private Vector3 velocidad = Vector3.zero;

    private bool mirandoDerecha = true;

    [Header("salto")]

    [SerializeField] private float furzaDeSalto;

    [SerializeField] private LayerMask queEsSuelo;

    [SerializeField] private Transform controladorSuelo;

    [SerializeField] private Vector3 dimensionesCaja;

    [SerializeField] private bool enSuelo;

    private bool salto = false;

    [Header("Rebote")]

    [SerializeField] private float velocidadRebote;

    [Header("Animacion")]

    private Animator animator;

    // Use this for initialization
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movimientoHorizontal = Input.GetAxisRaw("Horizontal") * velocidadDeMovimiento;
        animator.SetFloat("horisontal", Mathf.Abs(movimientoHorizontal));

        if (Input.GetKey(KeyCode.Space))
        {
            salto = true;
            rb2D.AddForce(new Vector2(0f, furzaDeSalto));
        }

    }

    private void FixedUpdate()
    {
        enSuelo = Physics2D.OverlapBox(controladorSuelo.position, dimensionesCaja, 0f, queEsSuelo);
        animator.SetBool("enSuelo", enSuelo);
        animator.SetFloat("VelocidadY", rb2D.linearVelocity.y);
       
        //Mover
        Mover(movimientoHorizontal * Time.fixedDeltaTime, salto);
        salto = false;
    }
    private void Mover(float Mover, bool saltar)
    {
        Vector3 velocidadObjetivo = new Vector2(Mover, rb2D.linearVelocity.y);
        rb2D.linearVelocity = Vector3.SmoothDamp(rb2D.linearVelocity, velocidadObjetivo, ref velocidad, suavizadoDeMovimiento);

        if (Mover > 0 && !mirandoDerecha)
        {
            //girar
            girar();
        }
        else if (Mover < 0 && mirandoDerecha)
        {
            //girar
            girar();
        }
        if (enSuelo && saltar)
        {
            enSuelo = false;
            rb2D.AddForce(new Vector2(0f, furzaDeSalto));
        }


    }

    public void Rebote()
    {
        rb2D.linearVelocity = new Vector2(rb2D.linearVelocity.x, velocidadRebote);

    }



    private void girar()
    {
        mirandoDerecha = !mirandoDerecha;
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(controladorSuelo.position, dimensionesCaja);
    }
}
