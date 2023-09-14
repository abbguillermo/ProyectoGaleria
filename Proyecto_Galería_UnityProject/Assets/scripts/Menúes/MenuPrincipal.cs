using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject BotonesMenu;
    public GameObject MenuOpciones;
    public GameObject MenuCreditos;
    public GameObject MenuLogros;

    void Start()
    {

    }

    public void Continuar()
    {
        //SceneManager.LoadScene("");
    }

    public void NuevaPartida()
    {
        SceneManager.LoadScene("Sala Inicial");
    }

    public void Logros()
    {
        BotonesMenu.SetActive(false);
        MenuLogros.SetActive(true);
    }

    public void Opciones()
    {
        BotonesMenu.SetActive(false);
        MenuOpciones.SetActive(true);
    }

    public void Creditos()
    {
        BotonesMenu.SetActive(false);
        MenuCreditos.SetActive(true);
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void Sala1()
    {
        SceneManager.LoadScene("Sala 1");
    }

    public void Sala2()
    {
        SceneManager.LoadScene("Sala2respawn");
    }

    public void Sala3()
    {
        SceneManager.LoadScene("Sala 3");
    }
}
