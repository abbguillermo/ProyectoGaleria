using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScroll : MonoBehaviour
{
    public GameObject[] objetos= new GameObject[3];
    public GameObject[] piezas = new GameObject[4];
    private int indiceArmaActual = 0;
    public bool pieza1 = false;
    public bool pieza2 = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RevisarCambioDeArma();
        
    }

    void CambiarArmaActual()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }

        objetos[indiceArmaActual].gameObject.SetActive(true);
    }

    void RevisarCambioDeArma()
    {
        float ruedaMouse = Input.GetAxis("Mouse ScrollWheel");
        if (ruedaMouse > 0f)
        {
            SeleccionarArmaAnterior();
          

        }
        else if (ruedaMouse < 0f)
        {
            SeleccionarArmaSiguiente();
            
        }
    }

    void SeleccionarArmaAnterior()
    {
        if (indiceArmaActual == 0)
        {
            indiceArmaActual = objetos.Length - 1;
        }
        else
        {
            indiceArmaActual--;
        }
        CambiarArmaActual();

    }

    void SeleccionarArmaSiguiente()
    {
        if (indiceArmaActual >= (objetos.Length - 1))
        {
            indiceArmaActual = 0;
        }
        else
        {
            indiceArmaActual++;
        }
        CambiarArmaActual();

    }

  public void agregar(GameObject objeto)
    {
        
        objetos[objetos.Length - 1] = gameObject.transform.GetChild(0).gameObject;
        objetos[objetos.Length - 1].SetActive(true);
        objetos[0].SetActive(false);
    }

  
}
