using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logica_Enemigo4 : MonoBehaviour
{
    public float velocidad = 2f;
    public float distanciadeteccion = 10f;
    public bool sube = false;
    public bool avanza = false;
    public GameObject reja1;
   

    // Update is called once per frame
    void Update()
    {
        if (sube&&transform.position.y<=1)
        {
            transform.Translate(Vector3.up * 0.3f* Time.deltaTime);
            avanza = true;
        }
        if (deteccion() && avanza && transform.position.y >= 1) 
        {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
        if (transform.position.x>=-17)
        {
            reja1.GetComponent<BoxCollider>().enabled = false;
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
