using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LogicaEnemigo_sala3 : MonoBehaviour
{
    public Transform PJ; 
    public float detectionRange = 10f;
    public deteccionruido ruido;

    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(new Vector3(Random.value+3, 1, Random.value+3));
        float distanciaPJ = Vector3.Distance(transform.position, PJ.position);
        if ( ruido.ruidito==true)
        {
            agent.SetDestination(PJ.position);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            agent.SetDestination(PJ.position);
        }
    }
}
