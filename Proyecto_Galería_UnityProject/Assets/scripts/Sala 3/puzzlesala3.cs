using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzlesala3 : MonoBehaviour
{
    //maniquies
    public GameObject objeto1;
    public GameObject objeto2;
    public GameObject objeto3;
    public GameObject objeto4;

    //trigger objetos
    public GameObject intobjeto1;
    public GameObject intobjeto2;
    public GameObject intobjeto3;
    public GameObject intobjeto4;

    public bool Objeto1bool;
    public bool Objeto2bool;
    public bool Objeto3bool;
    public bool Objeto4bool;

    public bool c1activo = false;
    public bool c2activo = false;
    public bool c3activo = false;

    public GameObject collider3;

    public GameObject rejas;
    public GameObject pedestales;
    public GameObject puerta;

    void Start()
    {
        FindObjectOfType<Agarrar>().distancia = 1f;
    }

    void Update()
    {
        Debug.Log(Objeto1bool);
        Debug.Log(Objeto2bool);
        Debug.Log(Objeto3bool);
        Debug.Log(Objeto4bool);
        if (Objeto1bool && Objeto2bool && Objeto3bool && Objeto4bool)
        {
           
            puerta.GetComponent<Animator>().Play("AbrirPuertaF");

        }

        if (c1activo == true && c2activo == true)
        {
            collider3.SetActive(true);
            if (c3activo == true)
            {
                objeto1.layer = 7;
                objeto2.layer = 7;
                objeto3.layer = 7;
                objeto4.layer = 7;
                intobjeto1.layer = 7;
                intobjeto2.layer = 7;
                intobjeto3.layer = 7;
                intobjeto4.layer = 7;
                rejas.GetComponent<Animator>().Play("AbrirRejas");
                FindObjectOfType<LogicaEnemigo_sala3>().sePuedeParar = true;
                
                StartCoroutine(Apertura());
            }
        }

        

        IEnumerator Apertura()
        {
            pedestales.transform.GetChild(0).GetComponent<AudioSource>().Play();
            c2activo = false;
            yield return new WaitForSeconds(0);
        }
    }
}
