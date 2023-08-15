using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccionruido : MonoBehaviour
{
    public bool ruidito = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "piso")
        {
            ruidito = true;
        }
    }
}
