using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bandera : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }




    }


}
