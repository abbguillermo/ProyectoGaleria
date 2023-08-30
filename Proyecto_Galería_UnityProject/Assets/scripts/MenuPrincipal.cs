using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
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
        //SceneManager.LoadScene("");
    }

    public void Opciones()
    {
        //SceneManager.LoadScene("");
    }

    public void Creditos()
    {
        //SceneManager.LoadScene("");
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Se cierra");
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
