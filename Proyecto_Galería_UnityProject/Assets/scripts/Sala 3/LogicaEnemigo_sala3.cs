using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class LogicaEnemigo_sala3 : MonoBehaviour
{
    public Transform[] waypoints;
    public Transform PJ;
    private int Index = 0;
    private NavMeshAgent agente;
    public bool puedeatacars3 = false;
    public bool cambiarWP = false;
    public bool puedemoverse;
    public bool sePuedeParar;
    public bool estacerca=false;
    public GameObject camara_jugador;
    public GameObject camara_muerte;
    int entro=0;
    public AudioSource sonidomuerte;
    public AudioClip grito;

    public GameObject sonidoenemigo;

    public AudioSource enemigoLevantandose;
    public AudioSource audioSourceEnemigo3;

    public GameObject enemigo;

    // Start is called before the first frame update
    void Start()
    {
        enemigo.GetComponent<Animator>().SetBool("isIdle", true);
        agente = GetComponent<NavMeshAgent>();
        //MoveToNextWaypoint();
        
    }

    void Update()
    {
        if (sePuedeParar)
        {
            enemigo.GetComponent<Animator>().SetBool("isStanding", true);
            enemigoLevantandose.enabled = true;
            StartCoroutine(Moverse());
        }

        if (puedemoverse)
        {
            enemigo.GetComponent<Animator>().SetBool("isWalking", true);
            audioSourceEnemigo3.enabled = true;

            if (puedeatacars3 == true && !Input.GetKey(KeyCode.LeftControl) && (PJ.position.x >= -6 && PJ.position.x <= 8))
            {
                agente.speed = 1.15f;
                enemigo.GetComponent<Animator>().SetBool("isRunning", true);
                agente.destination = PJ.position;
            }
            else
            {
                agente.speed = 1f;
                enemigo.GetComponent<Animator>().SetBool("isRunning", false);
                estacerca = false;
            }
            if ((Input.GetKey(KeyCode.LeftShift) || FindObjectOfType<deteccionruido>().ruidito) && (PJ.position.x >= -6 && PJ.position.x<=8))
            {
                enemigo.GetComponent<Animator>().SetBool("isRunning", true);
                agente.destination = PJ.position;
            }
            else if (!agente.pathPending && agente.remainingDistance < 0.5f)
            {
                MoveToNextWaypoint();
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && sePuedeParar)
        {
            Muerte();
        }
    }

    private void MoveToNextWaypoint()
    {
        if (waypoints.Length == 0)
            return;

        agente.destination = waypoints[Index].position;
        cambiarWP = true;
        if (cambiarWP)
        {

            Index = (Index + 1) % waypoints.Length;
            cambiarWP = false;
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

        SceneManager.LoadScene("Sala 3");
    }

    IEnumerator Moverse()
    {
        
        yield return new WaitForSeconds(6.9f);
        puedemoverse = true;
    }

}
