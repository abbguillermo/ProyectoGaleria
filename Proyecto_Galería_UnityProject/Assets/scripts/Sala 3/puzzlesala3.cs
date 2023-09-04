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
    public GameObject objeto5;
    public GameObject objeto6;
    //trigger objetos
    public GameObject intobjeto1;
    public GameObject intobjeto2;
    public GameObject intobjeto3;
    public GameObject intobjeto4;
    public GameObject intobjeto5;
    public GameObject intobjeto6;

    public bool Objeto1bool;
    public bool Objeto2bool;
    public bool Objeto3bool;
    public bool Objeto4bool;
    public bool Objeto5bool;
    public bool Objeto6bool;

    public bool c1activo = false;
    public bool c2activo = false;
    public bool c3activo = false;

    public GameObject rejas;
    public GameObject pedestales;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (c1activo == true && c2activo == true && c3activo == true)
        {
            objeto1.layer = 7;
            objeto2.layer = 7;
            objeto3.layer = 7;
            objeto4.layer = 7;
            objeto5.layer = 7;
            objeto6.layer = 7;
            intobjeto1.layer = 7;
            intobjeto2.layer = 7;
            intobjeto3.layer = 7;
            intobjeto4.layer = 7;
            intobjeto5.layer = 7;
            intobjeto6.layer = 7;
            //enemigoQuieto.SetActive(false);
            //enemigo.SetActive(true);
            Debug.Log("deberia activarse enemig");
            rejas.GetComponent<Animator>().Play("AbrirRejas");
            StartCoroutine(Apertura());
        }

        if (Objeto1bool && Objeto2bool && Objeto3bool && Objeto4bool && Objeto5bool && Objeto6bool)
        {
            Debug.Log("bien");
        }
        Debug.Log(Objeto1bool);
        Debug.Log(Objeto2bool);
        Debug.Log(Objeto3bool);
        Debug.Log(Objeto4bool);
        Debug.Log(Objeto5bool);
        Debug.Log(Objeto6bool);

        IEnumerator Apertura()
        {
            pedestales.transform.GetChild(0).GetComponent<AudioSource>().Play();
            c2activo = false;
            yield return new WaitForSeconds(0);
        }
    }
}
