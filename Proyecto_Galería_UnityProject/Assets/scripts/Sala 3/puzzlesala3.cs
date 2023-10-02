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

    public AudioSource audioSourcePuertas3;
    public AudioClip audioPuertas3;

    public GameObject luzobj1;
    public GameObject luzobj2;
    public GameObject luzobj3;
    public GameObject luzobj4;


    void Start()
    {
        if (FindObjectOfType<GameManager>().progreso())
        {
            c1activo = true;
            c2activo = true;
        }

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
            StartCoroutine(audioP());
            Objeto2bool = false;
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

        if(Objeto1bool == true)
        {
            luzobj1.GetComponent<Light>().color = new Color(0.6f, 1f, 0f, 1f);
        }
        else
        {
            luzobj1.GetComponent<Light>().color = new Color(1f, 1f, 1f, 1f);
        }

        if (Objeto2bool == true)
        {
            luzobj2.GetComponent<Light>().color = new Color(0.6f, 1f, 0f, 1f);
        }
        else
        {
            luzobj2.GetComponent<Light>().color = new Color(1f, 1f, 1f, 1f);
        }

        if (Objeto3bool == true)
        {
            luzobj3.GetComponent<Light>().color = new Color(0.6f, 1f, 0f, 1f);
        }
        else
        {
            luzobj3.GetComponent<Light>().color = new Color(1f, 1f, 1f, 1f);
        }

        if (Objeto4bool == true)
        {
            luzobj4.GetComponent<Light>().color = new Color(0.6f, 1f, 0f, 1f);
        }
        else
        {
            luzobj4.GetComponent<Light>().color = new Color(1f, 1f, 1f, 1f);
        }

        IEnumerator Apertura()
        {
            pedestales.transform.GetChild(0).GetComponent<AudioSource>().Play();
            c2activo = false;
            yield return new WaitForSeconds(0);
        }

        IEnumerator audioP()
        {
            audioSourcePuertas3.PlayOneShot(audioPuertas3);
            yield return new WaitForSeconds(0f);
        }
    }
}
