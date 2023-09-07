using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPausa : MonoBehaviour
{
    public GameObject MenuPausa;

    public bool pausado;


    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausado)
            {
                Reanudar();
            }
            else
            {
                PausarJuego();
            }
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
    }

    public void MenuPrincipal()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menú");
    }
}
