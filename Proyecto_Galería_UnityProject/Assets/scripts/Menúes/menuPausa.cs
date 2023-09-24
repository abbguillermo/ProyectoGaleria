using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuPausa : MonoBehaviour
{
    public GameObject MenuPausa;
    public GameObject MenuOpciones;
    public GameObject MenuCreditos;

    public static bool pausado;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(pausado)
            {
                Reanudar();
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                PausarJuego();
            }
        }
        
    }

    public void PausarJuego()
    {
        MenuPausa.SetActive(true);
        Time.timeScale = 0f;
        AudioListener.pause = true;
        pausado = true;
    }

    public void Reanudar()
    {
        MenuOpciones.SetActive(false);
        MenuCreditos.SetActive(false);
        MenuPausa.SetActive(false);
        Time.timeScale = 1f;
        AudioListener.pause = false;
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
        MenuPausa.SetActive(false);
        MenuCreditos.SetActive(true);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
