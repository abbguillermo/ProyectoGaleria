using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levantarparedes : MonoBehaviour
{
    public bool sala2 = false;
    public bool subir = false;
    public bool recolectables = false;
    public GameObject Laberinto;

    public bool recolectado1 = false;
    public bool recolectado2 = false;
    public bool recolectado3 = false;
    //public bool recolectado4 = false;
    public GameObject objetorecolectado1;
    public GameObject objetorecolectado2;
    public GameObject objetorecolectado3;
    //public GameObject objetorecolectado4;
    public GameObject pj;
    public GameObject TriggerBoxes;
    public GameObject Maniquies;
    public GameObject PuertaFinal;
    public GameObject PuertaInicio;

    //VARIABLE PARA ACTIVAR TRIGGER ENCUENTRO 2
    public bool pieza2 = false;

    private void Start()
    {
        FindObjectOfType<MenuPrincipal>().level_index = 2;
        PlayerPrefs.SetInt("guardadoSala", FindObjectOfType<MenuPrincipal>().level_index);
        sala2 = true;
    }

    void Update()
    {
        if (subir == true)
        {
            recolectables = true;
            FindObjectOfType<Agarrar>().palanca.layer = 0;
            FindObjectOfType<FirstPersonController>().playerCanMove = false;
            Laberinto.GetComponent<Animator>().Play("SubirLaberinto");
            PuertaInicio.GetComponent<Animator>().Play("CerrarPuerta");
            PuertaFinal.GetComponent<Animator>().Play("AbrirPuertaF");
            StartCoroutine(Movimiento());
        }

        if(pieza2 == true)
        {
            FindObjectOfType<Trigger>().encuentro2.SetActive(true);
            pieza2 = false;
        }

        /*if (recolectado1 == true && recolectado2 == true && recolectado3 == true && recolectado4 == true)
        {
            subir = false;
            //Laberinto.GetComponent<Animator>().Play("BajarLaberinto");
        }*/
        Debug.Log(recolectado1);
    }

    IEnumerator Movimiento()
    {
        Laberinto.transform.GetChild(0).GetComponent<AudioSource>().Play();
        subir = false;
        yield return new WaitForSeconds(5);
        FindObjectOfType<FirstPersonController>().playerCanMove = true;
        objetorecolectado1.layer = 7;
        objetorecolectado2.layer = 7;
        objetorecolectado3.layer = 7;
        //objetorecolectado4.layer = 7;
    }
}
