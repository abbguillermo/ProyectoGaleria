using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "trigs2/aceleracion")
        {
            agent.speed = 10;
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
            
        }
        
    }
}