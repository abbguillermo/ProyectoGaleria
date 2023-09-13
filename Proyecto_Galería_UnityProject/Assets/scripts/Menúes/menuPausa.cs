using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuPausa : MonoBehaviour
{
    public GameObject MenuPausa;
    public GameObject MenuOpciones;

    public static bool pausado;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            PausarJuego();
        }
    }

    public void PausarJuego()
    {
        MenuPausa.SetActive(true);
        Time.timeScale = 0f;
        pausado = true;
    }

    public void Reanudar()
    {
        MenuPausa.SetActive(false);
        Time.timeScale = 1f;
        pausado = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Opciones()
    {
        MenuPausa.SetActive(false);
        MenuOpciones.SetActive(true);
    }

    public void MenuPrincipal()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menú");
        pausado = false;
    }

    public void Créditos()
    {

    }

    public void Salir()
    {
        Application.Quit();
    }
}
