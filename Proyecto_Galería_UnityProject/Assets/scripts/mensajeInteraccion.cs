using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mensajeInteraccion : MonoBehaviour
{
    public GameObject mensaje;
    public bool interaccion=false;

    void Start()
    {
        
    }

   
    void Update()
    {
        if (interaccion)
        {
            mensaje.SetActive(true);
        }
        else
        {
            mensaje.SetActive(false);
        }
    }
}
