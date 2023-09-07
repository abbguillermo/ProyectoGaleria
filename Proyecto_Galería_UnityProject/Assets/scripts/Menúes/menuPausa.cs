using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuPausa : MonoBehaviour
{
    public GameObject MenuPausa;

    public static bool pausado;
    /*public Button volverMenu;

    void Start()
    {
        volverMenu.onClick.AddListener(MenuPrincipal);
    }*/

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

        if (Input.GetKeyDown(KeyCode.M))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Menú");
            pausado = false;
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
        Debug.Log("ENTRO AL MENU");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menú");

    }
}
