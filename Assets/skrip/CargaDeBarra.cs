using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CargaDeBarra : MonoBehaviour {
    public Image barradeprogreso;
    public float velocidad;
    float contador = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        contador = contador + (1 * Time.deltaTime);
        barradeprogreso.fillAmount = (1 - contador / velocidad);
	}

}
