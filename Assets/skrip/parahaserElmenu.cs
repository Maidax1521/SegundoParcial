using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
public class parahaserElmenu : MonoBehaviour {
    string Ruta = "Manual.pdf";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     public void menu()
{
       Process.Start(Ruta);
    }
}
