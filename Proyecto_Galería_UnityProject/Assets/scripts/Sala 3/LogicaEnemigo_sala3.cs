using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LogicaEnemigo_sala3 : MonoBehaviour
{
    public Transform PJ; 
    public float detectionRange = 10f;
    public float velocidad = 2;
    public deteccionruido ruido;
    public Transform[] WP;
    private int WPidx;
    bool cambiarWP;

    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
       // float distanciaPJ = Vector3.Distance(transform.position, PJ.position);
        if ( Input.GetKey(KeyCode.LeftShift))
        {
            agent.SetDestination(PJ.position);
        }
        if( !Input.GetKey(KeyCode.LeftShift))
        {
            if (WP.Length == 0)
            {
                Debug.LogWarning("No se han asignado waypoints al enemigo.");
                return;
            }
            Vector3 moveDirection = (WP[WPidx].position - transform.position).normalized;
            transform.Translate(moveDirection * velocidad * Time.deltaTime);

            // Si el enemigo está cerca del waypoint, pasa al siguiente
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            {
                MoveToNextWaypoint();
                cambiarWP = true;
            }
        }
       
    }

    private void MoveToNextWaypoint()
    {
        if (WP.Length == 0)
            return;

        agent.destination = WP[WPidx].position;
        if (cambiarWP)
        {

            WPidx = (WPidx + 1) % WP.Length;
            cambiarWP = false;
        }

    }
}
