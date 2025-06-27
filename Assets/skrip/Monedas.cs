using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas : MonoBehaviour
{
    [SerializeField] private GameObject Efecto;

    [SerializeField] private float CantidadPuntos;

    [SerializeField] private Puntaje puntaje;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Other.CompareTag("Player"))
        {
            Instantiate(Efecto, transform.position, Quaternion.identity);
            Destroy(gameObject);
            ControladorDePuntos.Instance.SumarPuntos(CantidadPuntos);
            puntaje.SumarPuntos(CantidadPuntos);
        }



    }






}

internal class Other
{
    public Other()
    {

    }

    internal static bool CompareTag(string v)
    {
        throw new NotImplementedException();
    }
}