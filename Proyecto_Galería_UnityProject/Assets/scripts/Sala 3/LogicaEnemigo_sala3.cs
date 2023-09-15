using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LogicaEnemigo_sala3 : MonoBehaviour
{
    public Transform[] waypoints;
    public Transform PJ;
    private int Index = 0;
    private NavMeshAgent agente;
    public bool puedeatacar = false;
    public bool cambiarWP = false;
    public bool puedemoverse;
    public bool sePuedeParar;
    public bool estacerca=false;

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
            StartCoroutine(Moverse());
        }

        if (puedemoverse)
        {
            enemigo.GetComponent<Animator>().SetBool("isWalking", true);

            if (puedeatacar == true && !Input.GetKey(KeyCode.LeftControl))
            {
                enemigo.GetComponent<Animator>().SetBool("isRunning", true);
                agente.destination = PJ.position;
            }
            else
            {
                enemigo.GetComponent<Animator>().SetBool("isRunning", false);
                estacerca = false;
            }
            if (Input.GetKey(KeyCode.LeftShift) || FindObjectOfType<deteccionruido>().ruidito)
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
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("MORISTE");
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

    IEnumerator Moverse()
    {
        yield return new WaitForSeconds(6.9f);
        puedemoverse = true;
    }

}
