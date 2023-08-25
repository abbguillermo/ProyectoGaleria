using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambioAudio : MonoBehaviour
{
    public AudioClip LatidoRapido;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("esconditeCamara"))
        {
            latidosManager.instance.cambiarLatido(LatidoRapido);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("esconditeCamara"))
        {
            latidosManager.instance.volverAlNormal();
        }
    }
}
