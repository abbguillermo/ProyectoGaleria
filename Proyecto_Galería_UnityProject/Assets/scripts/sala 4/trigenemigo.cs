using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigenemigo : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<Logica_Enemigo4>().Derrota();
        }
    }
}
