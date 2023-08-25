using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class latidosManager : MonoBehaviour
{
    public AudioClip latidoNormal;

    private AudioSource latidoRapido, latidoLento;
    private bool reproduciendoLatidoRapido;

    public static latidosManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        latidoRapido = gameObject.AddComponent<AudioSource>();
        latidoRapido.loop = true;
        latidoLento = gameObject.AddComponent<AudioSource>();
        latidoLento.loop = true;
        reproduciendoLatidoRapido = true;

        cambiarLatido(latidoNormal);
    }

    public void cambiarLatido(AudioClip newClip)
    {
        if (reproduciendoLatidoRapido)
        {
            latidoLento.clip = newClip;
            latidoLento.Play();
            latidoRapido.Stop();
        }
        else
        {
            latidoRapido.clip = newClip;
            latidoRapido.Play();
            latidoLento.Stop();
        }

        reproduciendoLatidoRapido = !reproduciendoLatidoRapido;
    }

    public void volverAlNormal()
    {
        cambiarLatido(latidoNormal);
    }
}
