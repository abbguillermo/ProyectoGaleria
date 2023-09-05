using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class triggerS2 : MonoBehaviour
{
    public GameObject enemigo;
    public NavMeshAgent agent;

    //cambiar velocidad
    public GameObject aceleracion1;
    public GameObject aceleracion2;

    //desactivar enemigo
    public GameObject desactivacion1;
    public GameObject desactivacion2;
    public GameObject desactivacion3;
    public GameObject desactivacion4;

    //cam muerte
    public GameObject camara_jugador;
    public GameObject camara_muerte;
    public AudioSource sonidomuerte;
    public AudioClip grito;
    private int entro = 0;

    public GameObject PuertaFinal;

    public GameObject maniquiesfinal;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void OnTriggerEnter(Collider other)
    {
        //MUERTE
        if (other.tag== "Player")
        {
            Muerte();
        }

        if (other.tag == "WP")
        {
            FindObjectOfType<Logicaenemigo_sala2>().cambiarWP = true;
        }

        if (other.tag == "trigs2/aceleracion")
        {
            agent.speed = 10;
        }

        if (other.tag == "trigs2/aceleracion2")
        {
            agent.speed = 1;
        }

        if (other.CompareTag("trigs2/desactivacion"))
        {
            Destroy(other.gameObject);
            enemigo.SetActive(false);
        }

        if (other.tag == "trigs2/activaceleracion")
        {
            aceleracion2.SetActive(true);
        }

        if(other.tag == "trigs2/activaDesac4")
        {
            desactivacion4.SetActive(true);
            maniquiesfinal.SetActive(true);
        }

    }
    void Muerte()
    {
        camara_jugador.SetActive(false);
        camara_muerte.SetActive(true);
        camara_muerte.GetComponent<Animator>().SetTrigger("shake");
        if (entro == 0)
        {
            sonidomuerte.PlayOneShot(grito);
            entro += 1;
        }
        StartCoroutine(pasajeescena());
       
    }
    IEnumerator pasajeescena()
    {
        yield return new WaitForSeconds(5f);
       
        SceneManager.LoadScene("Sala2respawn");
    }
}