using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tienpoDeVida : MonoBehaviour
{
    [SerializeField] private float tiempoDeVida;

    private void Start()
    {
        Destroy(gameObject, tiempoDeVida);
    }

}
