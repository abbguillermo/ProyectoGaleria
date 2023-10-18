using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class latidosManager : MonoBehaviour
{
    public AudioClip latidoNormal;

    private AudioSource latidoRapido /*track01*/, latidoLento;/*track02*/
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
        //latidoRapido.volume = 1f;
        latidoLento = gameObject.AddComponent<AudioSource>();
        latidoLento.loop = true;
        //latidoLento.volume = 1f;
        reproduciendoLatidoRapido = true;

        cambiarLatido(latidoNormal);
    }

    public void cambiarLatido(AudioClip newClip)
    {
        StopAllCoroutines();
        StartCoroutine(FadeTrack(newClip));
        reproduciendoLatidoRapido = !reproduciendoLatidoRapido;
    }

    public void volverAlNormal()
    {
        cambiarLatido(latidoNormal);
    }

    private IEnumerator FadeTrack(AudioClip newClip)
    {
        float timeToFade = 0.25f;
        float timeElapsed = 0;

        if (reproduciendoLatidoRapido)
        {
            latidoLento.clip = newClip;
            latidoLento.Play();

            while (timeElapsed < timeToFade)
            {
                latidoLento.volume = Mathf.Lerp(0, 1, timeElapsed / timeToFade);
                latidoRapido.volume = Mathf.Lerp(1, 0, timeElapsed / timeToFade);
                timeElapsed += Time.deltaTime;
                yield return null;
            }
            latidoRapido.Stop();
        }
        else
        {
            latidoRapido.clip = newClip;
            latidoRapido.Play();

            while (timeElapsed < timeToFade)
            {
                latidoRapido.volume = Mathf.Lerp(0, 1, timeElapsed / timeToFade);
                latidoLento.volume = Mathf.Lerp(1, 0, timeElapsed / timeToFade);
                timeElapsed += Time.deltaTime;
            }
            latidoLento.Stop();
        }
    }
}
