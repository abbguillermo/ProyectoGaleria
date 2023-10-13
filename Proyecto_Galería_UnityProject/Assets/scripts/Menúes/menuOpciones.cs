using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class menuOpciones : MonoBehaviour
{
    public GameObject MenuPausa;
    public GameObject MenuOpciones;
    public GameObject MenuCreditos;
    public GameObject MenuLogros;
    public GameObject BotonesMenu;

    public AudioMixer audioMixerMusica;
    public AudioMixer audioMixerSFX;

    public Slider musicaSlider;
    public Slider sfxSlider;

    void Start()
    {
        if (PlayerPrefs.HasKey("volumenMusica"))
        {
            CargarVolumen();
        }
        else
        {
            Musica(0f);
        }

        if (PlayerPrefs.HasKey("volumenSFX"))
        {
            CargarVolumenSFX();
        }
        else
        {
            Audio(0f);
        }
    }

    public void Musica(float volumen)
    {
        audioMixerMusica.SetFloat("volumenMusica", volumen);
        PlayerPrefs.SetFloat("volumenMusica", volumen);
    }

    public void CargarVolumen()
    {
        float volumen = musicaSlider.value;
        musicaSlider.value = PlayerPrefs.GetFloat("volumenMusica");
        volumen = PlayerPrefs.GetFloat("volumenMusica");
        Musica(volumen);
    }

    public void Audio(float volumenSFX)
    {
        audioMixerSFX.SetFloat("volumenSFX", volumenSFX);
        PlayerPrefs.SetFloat("volumenSFX", volumenSFX);
    }

    public void CargarVolumenSFX()
    {
        float volumen = sfxSlider.value;
        sfxSlider.value = PlayerPrefs.GetFloat("volumenSFX");
        volumen = PlayerPrefs.GetFloat("volumenSFX");
        Audio(volumen);
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
