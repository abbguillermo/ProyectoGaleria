using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicaManager : MonoBehaviour
{
    public AudioClip defaultAmbiente;

    private AudioSource persecuci�nAmbiente, otroAmbiente;
    private bool reproduciendoPersecuci�n;

    public static musicaManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        persecuci�nAmbiente = gameObject.AddComponent<AudioSource>();
        persecuci�nAmbiente.loop = true;
        otroAmbiente = gameObject.AddComponent<AudioSource>();
        otroAmbiente.loop = true;
        reproduciendoPersecuci�n = true;

        cambiarM�sica(defaultAmbiente);
    }

    public void cambiarM�sica(AudioClip newClip)
    {
        if (reproduciendoPersecuci�n)
        {
            otroAmbiente.clip = newClip;
            otroAmbiente.Play();
            persecuci�nAmbiente.Stop();
        }
        else
        {
            persecuci�nAmbiente.clip = newClip;
            persecuci�nAmbiente.Play();
            otroAmbiente.Stop();
        }

        reproduciendoPersecuci�n = !reproduciendoPersecuci�n;
    }

    public void volverAlDefault()
    {
        cambiarM�sica(defaultAmbiente);
    }
}
