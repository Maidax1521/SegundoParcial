using Assets.skrip;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeFuego : MonoBehaviour {

    [SerializeField] private Transform controladorDisparo;

    [SerializeField] private GameObject bala;

    [SerializeField] private readonly float maximoCarga;

    [SerializeField] private float tiempoDeCarga;


    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            
            tiempoDeCarga += Time.deltaTime;
        
        }


        


        if (Input.GetButtonUp("Fire1"))
        {
            
            Disparar((int) tiempoDeCarga);
            tiempoDeCarga = 0;
        }
    }

    private void Disparar (int tiempoDeCarga)
    {
        Vector3 crecer = new Vector3(tiempoDeCarga, tiempoDeCarga, 0);
        GameObject balaObjeto = Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);
        balaObjeto.GetComponent<Bala>().AumentarDaño(tiempoDeCarga);
        balaObjeto.transform.localScale += crecer;
    }

	
}

