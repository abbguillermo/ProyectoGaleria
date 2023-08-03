using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEnemigo01 : MonoBehaviour
{
    public Transform PJ;
    public float velocidadPersecusion;
    public bool papel=false;
    public bool puedemov = true;
    public Vector3 pos1;
    public Vector3 pos2;
    public Vector3 pos3;
    public Vector3 pos4;
    public Vector3 pos5;
    public Vector3 pos6;
    public Vector3 pos7;
    public GameObject camara_jugador;
    public GameObject camara_muerte;
    public GameObject enemigo;
    /*public float tiempoinicial;
    public bool estaactivado;*/
    public float tiempo;
    public bool avanzaprimertrigger;
    public bool avanzasegundotrigger;
    public bool avanzatercertrigger;
    public bool avanzacuartotrigger;
    public bool avanzaquintotrigger;

    // Start is called before the first frame update
    void Start()
    {
        avanzaprimertrigger = false;
        avanzasegundotrigger = false;
        avanzatercertrigger = false;
        avanzacuartotrigger = false;
        avanzaquintotrigger = false;
        //tiempo;
        //estaactivado = false;
        enemigo = gameObject;
        /*pos1 = new Vector3(-1.9f, 1.1f, 2.98f);
        pos2 = new Vector3(2.79f, 1.1f, 4);
        pos3 = new Vector3(0, 0, 0);
        pos4 = new Vector3(0, 0, 0);
        pos5 = new Vector3(0, 0, 0);
        pos6 = new Vector3(0, 0, 0);*/
    }

    void Update()
    {

       /* if (estaactivado)
        {
            tiempo = Time.time; 
        }*/
   
        if (papel==true/*&& puedemov==true*/)
        {
            tiempo += Time.deltaTime;
            posicion1();
            //encendertiempo();
            //StartCoroutine(posiciones());
            if ((tiempo >= 20 && tiempo <= 239))
            {
                posicion2();
            }
            if ((tiempo >= 240 && tiempo <= 300) || avanzaprimertrigger) //1MIN
            {
                posicion3();
                
            }
            if ((tiempo >= 301 && tiempo <= 540) || avanzasegundotrigger) //4MIN
            {
                posicion4();

            }
            if ((tiempo >= 541 && tiempo <= 600) || avanzatercertrigger)
            {
                posicion5();

            }
            if ((tiempo >= 601 && tiempo <= 840) || avanzacuartotrigger)
            {
                posicion6();

            }
            if ((tiempo >= 841 && tiempo <= 1000) || avanzaquintotrigger)
            {
                posicion7();

            }
            /* puedemov = false;*/
        }

       

        Debug.Log(avanzaprimertrigger);
        if (gameObject.transform.position.x>PJ.position.x)
        {
           // Derrota();
        }
       
    }

   /* IEnumerator posiciones()
    {
        gameObject.transform.position = pos1;
        yield return new WaitForSeconds(10f);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        gameObject.transform.GetChild(2).gameObject.SetActive(true);
        gameObject.transform.position = pos2;
        yield return new WaitForSeconds(240);
        gameObject.transform.GetChild(2).gameObject.SetActive(false);
        gameObject.transform.GetChild(3).gameObject.SetActive(true);
        gameObject.transform.position = pos3;
        yield return new WaitForSeconds(45);
        gameObject.transform.GetChild(3).gameObject.SetActive(false);
        gameObject.transform.GetChild(4).gameObject.SetActive(true);
        gameObject.transform.position = pos4;
        yield return new WaitForSeconds(200);
        gameObject.transform.GetChild(4).gameObject.SetActive(false);
        gameObject.transform.GetChild(3).gameObject.SetActive(true);
        gameObject.transform.position = pos5;
        yield return new WaitForSeconds(45);
        gameObject.transform.GetChild(3).gameObject.SetActive(false);
        gameObject.transform.GetChild(5).gameObject.SetActive(true);
        gameObject.transform.position = pos6;
        yield return new WaitForSeconds(200);
        gameObject.transform.GetChild(5).gameObject.SetActive(false);
        gameObject.transform.GetChild(6).gameObject.SetActive(true);
        gameObject.transform.position = pos7;
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player" && papel==true)
        {
            Derrota();
        }
    }
    private void Derrota()
    {
        camara_jugador.SetActive(false);
        camara_muerte.SetActive(true);
    }

    public void posicion1()
    {
        gameObject.transform.GetChild(1).gameObject.SetActive(true);
        gameObject.transform.position = pos1;
    }
    void posicion2()
    {
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        gameObject.transform.GetChild(2).gameObject.SetActive(true);
        gameObject.transform.position = pos2;
    }
    void posicion3()
    {
        gameObject.transform.GetChild(2).gameObject.SetActive(false);
        gameObject.transform.GetChild(3).gameObject.SetActive(true);
        gameObject.transform.position = pos3;
    }
    void posicion4()
    {
        gameObject.transform.GetChild(3).gameObject.SetActive(false);
        gameObject.transform.GetChild(4).gameObject.SetActive(true);
        gameObject.transform.position = pos4;
    }
    void posicion5()
    {
        gameObject.transform.GetChild(4).gameObject.SetActive(false);
        gameObject.transform.GetChild(3).gameObject.SetActive(true);
        gameObject.transform.position = pos5;
    }
    void posicion6()
    {
        gameObject.transform.GetChild(3).gameObject.SetActive(false);
        gameObject.transform.GetChild(5).gameObject.SetActive(true);
        gameObject.transform.position = pos6;
    }
    void posicion7()
    {
        gameObject.transform.GetChild(5).gameObject.SetActive(false);
        gameObject.transform.GetChild(6).gameObject.SetActive(true);
        gameObject.transform.position = pos7;
    }
/*
    public void detenertiempo()
    {
        estaactivado = false;
        
    }
    public void encendertiempo()
    {
        tiempoinicial = Time.time;
        estaactivado = true;
    }*/
}
