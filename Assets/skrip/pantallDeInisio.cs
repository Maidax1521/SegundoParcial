using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pantallDeInisio : MonoBehaviour {
    float tiempo = 0;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        tiempo += Time.deltaTime;
        if (tiempo >= 2.0f)

        {
            SceneManager.LoadScene("menus");
        }
    }
}











