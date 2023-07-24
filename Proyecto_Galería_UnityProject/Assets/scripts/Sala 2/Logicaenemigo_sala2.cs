using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Logicaenemigo_sala2 : MonoBehaviour
{
    public Transform[] waypoints;
    private int Index = 0;
    private NavMeshAgent agente;

    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        MoveToNextWaypoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (!agente.pathPending && agente.remainingDistance < 0.5f)
        {
            MoveToNextWaypoint();
        }
    }

    private void MoveToNextWaypoint()
    {
        if (waypoints.Length == 0)
            return;

        agente.destination = waypoints[Index].position;
        Index = (Index + 1) % waypoints.Length;
    }

}
