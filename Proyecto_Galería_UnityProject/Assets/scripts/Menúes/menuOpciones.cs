using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuOpciones : MonoBehaviour
{
    public GameObject MenuPausa;
    public GameObject MenuOpciones;
    public GameObject MenuCreditos;
    public GameObject BotonesMenu;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Musica()
    {

    }

    public void Audio()
    {

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


}
