using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LogicaEnemigo2 : MonoBehaviour
{
    public float detectionRadius = 10f;

    private NavMeshAgent agent;
    private Transform target;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {



        if (target == null)
        {


            // Buscar al jugador más cercano
            Collider[] colliders = Physics.OverlapSphere(transform.position, detectionRadius);
            float minDistance = Mathf.Infinity;
            foreach (Collider collider in colliders)
            {
                if (collider.CompareTag("Player"))
                {


                    float distance = Vector3.Distance(transform.position, collider.transform.position);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        target = collider.transform;
                    }


                }
            }

        }


        if (target != null)
        {
            if(!Input.GetKey(KeyCode.LeftControl)){
                agent.SetDestination(target.position);
            }
            



            // Si el enemigo está cerca del jugador, atacarlo
            if (Vector3.Distance(transform.position, target.position) < agent.stoppingDistance)
            {
                Attack();
            }
        }
    }

    private void Attack()
    {
        // Implementar el comportamiento de ataque del enemigo
    }
}


