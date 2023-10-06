using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Logica_Enemigo4 : MonoBehaviour
{
    public float velocidad = 2f;
    public float distanciadeteccion = 10f;
    public bool sube = false;
    public bool avanza = false;

    public bool interactuoCuadro = false;

    public bool teleportPared1 = false;
    public bool teleportPared2 = false;
    public bool teleportPared3 = false;
    public bool muņecoAgarrado = false;

    public GameObject cuadroInicio;
    public GameObject cuadro2S4;
    public GameObject cuadro3S4;
    public GameObject cuadro4S4;
    public GameObject cuadro5S4;
    public GameObject cuadro6S4;

    public GameObject reja1;
    public GameObject triggerPared2;

    public Volume m_Volume;
    public ColorAdjustments ca;


    // Update is called once per frame
    void Update()
    {
        if (sube&&transform.position.y<=0.2)
        {
            transform.Translate(Vector3.up * 0.3f * Time.deltaTime);
            //avanza = true;
        }

        if (transform.position.y >= 0.2)
        {
            cuadroInicio.layer = 7;
        }

        if (deteccion() && avanza && transform.position.y >= 0.2) 
        {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }

        if (transform.position.x>=-17)
        {
            reja1.GetComponent<BoxCollider>().enabled = false;
        }

        if (interactuoCuadro)
        {
            Enemigo();
        }

        if (teleportPared1)
        {
            transform.position = new Vector3(-12, transform.position.y, transform.position.z);
            teleportPared1 = false;
        }

        if (muņecoAgarrado)
        {
            triggerPared2.SetActive(true);
            if (teleportPared2)
            {
                transform.position = new Vector3(-4, transform.position.y, transform.position.z);
                teleportPared2 = false;
            }
        }

        if (teleportPared3)
        {
            transform.position = new Vector3(4, transform.position.y, transform.position.z);
            teleportPared3 = false;
            avanza = false;
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

    void Enemigo()
    {
        StartCoroutine(CambiarCuadros());
    }

    IEnumerator CambiarCuadros()
    {
        m_Volume.profile.TryGet(out ca);
        if (ca.postExposure.value > -5f)
        {
            ca.postExposure.value -= 100f;
        }
        interactuoCuadro = false;
        cuadroInicio.SetActive(false);
        cuadro2S4.SetActive(true);
        yield return new WaitForSeconds(1f);
        ca.postExposure.value = 2.5f;
        yield return new WaitForSeconds(2f);
        //cuadro 2
        if (ca.postExposure.value > -5f)
        {
            ca.postExposure.value -= 100f;
        }
        cuadro2S4.SetActive(false);
        cuadro3S4.SetActive(true);
        yield return new WaitForSeconds(1f);
        ca.postExposure.value = 2.5f;
        yield return new WaitForSeconds(2f);
        //cuadro 3
        if (ca.postExposure.value > -5f)
        {
            ca.postExposure.value -= 100f;
        }
        cuadro3S4.SetActive(false);
        cuadro4S4.SetActive(true);
        yield return new WaitForSeconds(1f);
        ca.postExposure.value = 2.5f;
        yield return new WaitForSeconds(2f);
        //cuadro 4
        if (ca.postExposure.value > -5f)
        {
            ca.postExposure.value -= 100f;
        }
        cuadro4S4.SetActive(false);
        cuadro5S4.SetActive(true);
        yield return new WaitForSeconds(1f);
        ca.postExposure.value = 2.5f;
        yield return new WaitForSeconds(2f);
        //cuadro 5
        if (ca.postExposure.value > -5f)
        {
            ca.postExposure.value -= 100f;
        }
        cuadro5S4.SetActive(false);
        cuadro6S4.SetActive(true);
        yield return new WaitForSeconds(1f);
        ca.postExposure.value = 2.5f;
        yield return new WaitForSeconds(2f);
        //cuadro 6
        //aparece bicho
        yield return new WaitForSeconds(1f);
    }

    /*IEnumerator bajarExposure()
    {
        ca.postExposure.value -= 0.5f;
        yield return new WaitForSeconds(0.01f);
        ca.postExposure.value -= 0.5f;
        yield return new WaitForSeconds(0.01f);
        ca.postExposure.value -= 0.5f;
        yield return new WaitForSeconds(0.01f);
        ca.postExposure.value -= 0.5f;
        yield return new WaitForSeconds(0.01f);
    }*/

}
