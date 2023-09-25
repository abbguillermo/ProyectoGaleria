using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private Vector3 posicionactual;
    private bool pasaje;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void guardarProgreso(Vector3 posicion, bool estado)
    {
        posicionactual = posicion;
        pasaje = estado;
    }

    public Vector3 cargarProgreso()
    {
        return posicionactual;
        
    }
    public bool progreso()
    {
        return pasaje;
    }
}
