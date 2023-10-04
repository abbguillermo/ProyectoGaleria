using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliders4 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<Logica_Enemigo4>().sube = true;
            Destroy(this.gameObject);
        }
    }
}
