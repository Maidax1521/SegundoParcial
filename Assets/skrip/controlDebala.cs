using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlDebala : MonoBehaviour
{
    [SerializeField] private float velocidad;

    [SerializeField] private float dano;

    private void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
    }

    public void AumentarDaño(int danoExtra)
    {
        dano += danoExtra * dano;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo"))
        {
            other.GetComponent<Enemigo>().TomarDaño(dano);
            Debug.Log("daño : " + dano);
            Destroy(gameObject);
        }
    }

}
