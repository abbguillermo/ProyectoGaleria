using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzlesala3 : MonoBehaviour
{
    /*public GameObject objeto1;
    public GameObject objeto2;
    public GameObject objeto3;
    public GameObject objeto4;
    public GameObject objeto5;
    public GameObject objeto6;*/
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
    public AudioSource audioRejas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (c1activo == true && c2activo == true && c3activo == true)
        {
            //enemigoQuieto.SetActive(false);
            //enemigo.SetActive(true);
            Debug.Log("deberia activarse enemig");
            rejas.GetComponent<Animator>().Play("AbrirRejas");
            audioRejas.Play();
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
    }
}
