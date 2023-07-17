using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levantarparedes : MonoBehaviour
{

    public bool subir = false;
    public GameObject Laberinto;

    public bool recolectado1 = false;
    public bool recolectado2 = false;
    public bool recolectado3 = false;
    public bool recolectado4 = false;

    void Update()
    {
        if (subir == true)
        {
            FindObjectOfType<FirstPersonController>().playerCanMove = false;
            Laberinto.GetComponent<Animator>().Play("SubirLaberinto");
            StartCoroutine(Movimiento());
        }

        if (recolectado1 == true && recolectado2 == true && recolectado3 == true && recolectado4 == true)
        {
            subir = false;
            Laberinto.GetComponent<Animator>().Play("BajarLaberinto");
        }
    }

    IEnumerator Movimiento()
    {
        yield return new WaitForSeconds(5);
        FindObjectOfType<FirstPersonController>().playerCanMove = true;
    }
}
