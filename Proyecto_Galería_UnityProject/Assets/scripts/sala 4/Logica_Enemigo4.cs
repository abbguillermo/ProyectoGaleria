using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logica_Enemigo4 : MonoBehaviour
{
    public float velocidad = 2f;
    public float distanciadeteccion = 10f;
   

    // Update is called once per frame
    void Update()
    {
        if (deteccion())
        {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
        
    }

    bool deteccion()
    {
        RaycastHit hit;
        Debug.DrawLine(transform.position, transform.position + transform.forward * distanciadeteccion, Color.red, 0.5f);
        if (Physics.Raycast(transform.position, transform.forward, out hit, distanciadeteccion))
        {
            if (hit.collider.CompareTag("Espalda"))
            {
                return true;
            }
        }
        return false;
    }
}
