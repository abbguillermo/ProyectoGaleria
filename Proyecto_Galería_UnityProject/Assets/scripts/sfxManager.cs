using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfxManager : MonoBehaviour
{
    public AudioSource Audio;

    //se carga el sonido 
    public AudioClip sfxPuerta;
    public AudioClip sfxAgarreCuadro;
    public AudioClip sfxRotadoCuadro;
    //public AudioClip sfxPuertaDeslizada;
    public AudioClip sfxInterruptor;

    public static sfxManager sfxInstance;

    private void Awake()
    {
        if (sfxInstance != null && sfxInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        sfxInstance = this;
        DontDestroyOnLoad(this);
    }
}
