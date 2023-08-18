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

    // Start is called before the first frame update
    void Start()
    {

        agente = GetComponent<NavMeshAgent>();
        MoveToNextWaypoint();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Index);

        if (Input.GetKey(KeyCode.LeftShift)||FindObjectOfType<deteccionruido>().ruidito)
        {
            agente.destination = PJ.position;
        }
        else if (!agente.pathPending && agente.remainingDistance < 0.5f)
        {
            MoveToNextWaypoint();
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
}
