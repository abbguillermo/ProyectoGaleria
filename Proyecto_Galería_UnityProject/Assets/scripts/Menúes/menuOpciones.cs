using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class menuOpciones : MonoBehaviour
{
    public GameObject MenuPausa;
    public GameObject MenuOpciones;
    public GameObject MenuCreditos;
    public GameObject MenuLogros;
    public GameObject BotonesMenu;

    public AudioMixer audioMixerMusica;
    public AudioMixer audioMixerSFX;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Musica(float volumen)
    {
        audioMixerMusica.SetFloat("volumenMusica", volumen);
    }

    public void Audio(float volumenSFX)
    {
        audioMixerSFX.SetFloat("volumenSFX", volumenSFX);
    }

    public void Idioma()
    {

    }

    public void Subtitulos()
    {

    }

    public void AtrasOpcionesEscenas()
    {
        MenuOpciones.SetActive(false);
        MenuPausa.SetActive(true);
    }

    public void AtrasCreditosEscenas()
    {
        MenuCreditos.SetActive(false);
        MenuPausa.SetActive(true);
    }

    public void AtrasMenu()
    {
        MenuOpciones.SetActive(false);
        BotonesMenu.SetActive(true);
    }

    public void AtrasCreditos()
    {
        MenuCreditos.SetActive(false);
        BotonesMenu.SetActive(true);
    }

    public void AtrasLogros()
    {
        MenuLogros.SetActive(false);
        BotonesMenu.SetActive(true);
    }


}
