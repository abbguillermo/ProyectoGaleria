using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicaManager : MonoBehaviour
{
    public AudioClip defaultAmbiente;

    private AudioSource persecuciónAmbiente, otroAmbiente;
    private bool reproduciendoPersecución;

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
        persecuciónAmbiente = gameObject.AddComponent<AudioSource>();
        persecuciónAmbiente.loop = true;
        otroAmbiente = gameObject.AddComponent<AudioSource>();
        otroAmbiente.loop = true;
        reproduciendoPersecución = true;

        cambiarMúsica(defaultAmbiente);
    }

    public void cambiarMúsica(AudioClip newClip)
    {
        if (reproduciendoPersecución)
        {
            otroAmbiente.clip = newClip;
            otroAmbiente.Play();
            persecuciónAmbiente.Stop();
        }
        else
        {
            persecuciónAmbiente.clip = newClip;
            persecuciónAmbiente.Play();
            otroAmbiente.Stop();
        }

        reproduciendoPersecución = !reproduciendoPersecución;
    }

    public void volverAlDefault()
    {
        cambiarMúsica(defaultAmbiente);
    }
}
