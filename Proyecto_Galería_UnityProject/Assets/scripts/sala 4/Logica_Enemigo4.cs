using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

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
    public bool muñecoAgarrado = false;

    //muerte
    private int entro = 0;
    public GameObject camara_jugador;
    public GameObject camara_muerte;
    public GameObject enemigoCamMuerte;
    public GameObject personaje;
    public AudioSource audiomuerte;
    public AudioClip grito;


    //public bool activarPalanca = false;

    public GameObject cuadroInicio;
    public GameObject cuadro2S4;
    public GameObject cuadro3S4;
    public GameObject cuadro4S4;
    public GameObject cuadro5S4;
    public GameObject cuadro6S4;

    public GameObject EnemigoA1;

    public GameObject reja1;
    public GameObject triggerPared2;

    public Volume m_Volume;
    public ColorAdjustments ca;

    public float exposición_Oscuro = 7f;

    private void Start()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Derrota();
        }
    }
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

        if (muñecoAgarrado)
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
            Invoke("EnemigoSale", 8.5f);
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
            //cuadro 1
            ca.postExposure.value -= exposición_Oscuro;
            interactuoCuadro = false;
            cuadroInicio.SetActive(false);
            cuadro2S4.SetActive(true);
            yield return new WaitForSeconds(1f);
            ca.postExposure.value = 2.5f;
            yield return new WaitForSeconds(3f);

            //cuadro 2
            ca.postExposure.value -= exposición_Oscuro;
            cuadro2S4.SetActive(false);
            cuadro3S4.SetActive(true);
            yield return new WaitForSeconds(1f);
            ca.postExposure.value = 2.5f;
            yield return new WaitForSeconds(2f);

            //cuadro 3
            ca.postExposure.value -= exposición_Oscuro;
            cuadro3S4.SetActive(false);
            cuadro4S4.SetActive(true);
            yield return new WaitForSeconds(1f);
            ca.postExposure.value = 2.5f;
            yield return new WaitForSeconds(2f);

            //cuadro 4
            ca.postExposure.value -= exposición_Oscuro;
            cuadro4S4.SetActive(false);
            cuadro5S4.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            ca.postExposure.value = 2.5f;
            yield return new WaitForSeconds(2f);

            //cuadro 5
            ca.postExposure.value -= exposición_Oscuro;
            cuadro5S4.SetActive(false);

            //cuadro 6
            cuadro6S4.SetActive(true);
            EnemigoA1.SetActive(true);
            avanza = true;
            FindObjectOfType<Agarrar>().palancas4.layer = 7;
            EnemigoA1.GetComponent<Animator>().SetBool("Parte 1", true);
            EnemigoA1.GetComponent<Animator>().SetBool("Parte 2", true);
            gameObject.GetComponent<BoxCollider>().enabled = true;
            yield return new WaitForSeconds(0.5f);
            ca.postExposure.value = 2.5f;
        }
    }

    private void Derrota()
    {
        camara_jugador.SetActive(false);
        camara_muerte.SetActive(true);
        camara_muerte.GetComponent<Animator>().SetTrigger("shake");
        enemigoCamMuerte.GetComponent<Animator>().Play("Muerte4");
        personaje.SetActive(false);

        if (entro == 0)
        {

            audiomuerte.PlayOneShot(grito);

            entro += 1;

        }

        StartCoroutine(pasajeescena());
    }

    IEnumerator pasajeescena()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Sala 4");
    }

    void EnemigoSale()
    {
        EnemigoA1.GetComponent<Animator>().SetBool("Parte 3", true);
        StartCoroutine(saltoenemigo());
    }

    IEnumerator saltoenemigo()
    {
        yield return new WaitForSeconds(1f);
        gameObject.transform.GetChild(1).transform.Translate(Vector3.forward * 6000 * Time.deltaTime);
    }
}
