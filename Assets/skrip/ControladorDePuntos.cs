using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDePuntos : MonoBehaviour
{

    public static ControladorDePuntos Instance;

    [SerializeField] private float cantidadPuntos;

    private void Awake()
    {
        if (ControladorDePuntos.Instance == null)
        {
            ControladorDePuntos.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
    public void SumarPuntos(float puntos)
    {
        cantidadPuntos += puntos;
    }
















}
