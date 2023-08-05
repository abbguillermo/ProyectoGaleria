using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Agarrar : MonoBehaviour
{
    public GameObject pared;
    public float distancia = 3f;
    public LayerMask capaObjetos;
    public LayerMask capaPiezas;
    public LayerMask capainterac;
    public Transform puntodeagarre;
    public Transform marcopos1;
    public Vector3 marcopos2;
    public Vector3 marcopos3;
    public Vector3 marcopos4;
    public Quaternion marcorot;
    public bool puedeagarrar;
    public GameObject puerta;
    public GameObject escondite1_sala2;
    public GameObject spriteNota;
    public GameObject palanca;
    public GameObject osito;
    public GameObject cuchillo;
    public GameObject mecha;
    private GameObject hitmaniqui1;
    private GameObject hitmaniqui2;
    private GameObject hitmaniqui3;

    //Objetos sala inicial
    public GameObject radio;
    public GameObject cuadro;


    public ControlScroll mano;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
        Debug.DrawLine(transform.position, transform.position + transform.forward * distancia, Color.red, 0.5f);
        //notificacion interaccion
        
      


            RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, distancia, capainterac))
        {
            FindObjectOfType<mensajeInteraccion>().interaccion = true;
        }
        else
        {
            FindObjectOfType<mensajeInteraccion>().interaccion = false;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, distancia, capaObjetos))
            { 
                GameObject objetoRecolectado = hit.transform.gameObject;

                mano.agregar(objetoRecolectado);
                hit.transform.gameObject.SetActive(false);  
            }
            else if (Physics.Raycast(transform.position, transform.forward, out hit, distancia, capaPiezas))
            {
                if (hit.transform.gameObject.tag=="Pieza1")
                {
                    
                    mano.pieza1=true;
                    hit.transform.gameObject.SetActive(false);
                }else if (hit.transform.gameObject.tag == "Pieza2")
                {
                    mano.pieza2 = true;
                    hit.transform.gameObject.SetActive(false);
                }
            }


            if(Physics.Raycast(transform.position, transform.forward, out hit, distancia, capainterac))
            {
                //sala inicial
                if (hit.transform.gameObject.tag == "salainicial/radio")
                {
                    radio.GetComponent<AudioSource>().Play();
                    FindObjectOfType<Logica_Gral>().gameObject.layer = 7;
                    radio.layer = 0;
                }
                if (hit.transform.gameObject.tag == "salainicial/cuadro")
                {
                    FindObjectOfType<Logica_Gral>().Rotarcuad1();
                    sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxRotadoCuadro);
                }

                //escondites
                if (hit.transform.gameObject.tag == "escondites/escondite1")
                {
                    //Debug.Log("sadsaw");
                    hit.transform.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                    escondite1_sala2.SetActive(false);
                }

                //agarre puzzle 1
                if (puedeagarrar == true)
                {
                    if (hit.transform.gameObject.tag == "cuadro0" || hit.transform.gameObject.tag == "cuadro1"|| hit.transform.gameObject.tag == "cuadro2"|| hit.transform.gameObject.tag == "cuadro3"|| hit.transform.gameObject.tag == "cuadro4")
                    {
                        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxAgarreCuadro);
                        GameObject objeto = hit.transform.gameObject;

                        objeto.transform.SetParent(puntodeagarre);
                        objeto.transform.localPosition = Vector3.zero;
                        objeto.transform.localRotation = Quaternion.identity;
                        puedeagarrar = false;

                    }
                   
                }
                if(puedeagarrar=false && hit.transform.gameObject.tag == "cuadro0" || hit.transform.gameObject.tag == "cuadro1" || hit.transform.gameObject.tag == "cuadro2" || hit.transform.gameObject.tag == "cuadro3" || hit.transform.gameObject.tag == "cuadro4")
                {
                    sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxAgarreCuadro);
                    GameObject.FindGameObjectWithTag("mano").gameObject.transform.GetChild(0);

                    GameObject.FindGameObjectWithTag("mano").gameObject.transform.GetChild(0).gameObject.transform.position = new Vector3(hit.transform.position.x , hit.transform.position.y, hit.transform.position.z);
                    GameObject.FindGameObjectWithTag("mano").gameObject.transform.GetChild(0).gameObject.transform.rotation = marcorot;
                    GameObject.FindGameObjectWithTag("mano").gameObject.transform.GetChild(0).SetParent(pared.transform);
                    hit.transform.SetParent(puntodeagarre);
                    hit.transform.localPosition = Vector3.zero;
                    hit.transform.localRotation = Quaternion.identity;
                    puedeagarrar = false;
                }
                    if (hit.transform.gameObject.tag == "marco1"|| hit.transform.gameObject.tag == "marco2" || hit.transform.gameObject.tag == "marco3"|| hit.transform.gameObject.tag == "marco4")
                    {
                        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxAgarreCuadro);
                        GameObject.FindGameObjectWithTag("mano").gameObject.transform.GetChild(0);
                        
                        GameObject.FindGameObjectWithTag("mano").gameObject.transform.GetChild(0).gameObject.transform.position = new Vector3(hit.transform.position.x, hit.transform.position.y, hit.transform.position.z);
                        GameObject.FindGameObjectWithTag("mano").gameObject.transform.GetChild(0).gameObject.transform.rotation = marcorot;
                        GameObject.FindGameObjectWithTag("mano").gameObject.transform.GetChild(0).SetParent(pared.transform);
                        puedeagarrar = true;

                    }

                //hasta aca el agarre del puzzle 1
                //puzzle 2
                if (hit.transform.gameObject.tag == "marcorot1" )
                {
                    FindObjectOfType<puzzle2>().Rotarcuad1();
                    sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxRotadoCuadro);
                }
                if(hit.transform.gameObject.tag == "marcorot2" )
                {
                    FindObjectOfType<puzzle2>().Rotarcuad2();
                    sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxRotadoCuadro);
                }
                if ( hit.transform.gameObject.tag == "marcorot3")
                {
                    FindObjectOfType<puzzle2>().Rotarcuad3();
                    sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxRotadoCuadro);
                }
                if (hit.transform.gameObject.tag == "marcorot4")
                {
                    FindObjectOfType<puzzle2>().Rotarcuad4();
                    sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxRotadoCuadro);
                }

                if (hit.transform.gameObject.tag== "botonespuzzle2/boton1")
                {
                    FindObjectOfType<puzzle2>().boton1();
                    sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxInterruptor);
                }
                if (hit.transform.gameObject.tag == "botonespuzzle2/boton2")
                {
                    FindObjectOfType<puzzle2>().boton2();
                    sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxInterruptor);
                }
                if (hit.transform.gameObject.tag == "botonespuzzle2/boton3")
                {
                    FindObjectOfType<puzzle2>().boton3();
                    sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxInterruptor);
                }
                if (hit.transform.gameObject.tag == "botonespuzzle2/boton4")
                {
                    FindObjectOfType<puzzle2>().boton4();
                    sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxInterruptor);
                }

                if (hit.transform.gameObject.tag == "btnincorrectos")
                {
                    sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxInterruptor);
                }

                //hasta aca puzzle 2
                //puzzle tri
                if (hit.transform.gameObject.tag == "cuadroP3/marcorot1")
                {
                    FindObjectOfType<puzzle3>().Rotarcuad1();
                    sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxInterruptor);
                }
                if (hit.transform.gameObject.tag == "cuadroP3/marcorot2")
                {
                    FindObjectOfType<puzzle3>().Rotarcuad2();
                    sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxInterruptor);
                }
                if (hit.transform.gameObject.tag == "cuadroP3/marcorot3")
                {
                    FindObjectOfType<puzzle3>().Rotarcuad3();
                    sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxInterruptor);
                }
                if (hit.transform.gameObject.tag == "cuadroP3/marcorot4")
                {
                    FindObjectOfType<puzzle3>().Rotarcuad4();
                    sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxInterruptor);
                }
                //hasta aca puzzle tri
                //agarre de papelito
                if (hit.transform.gameObject.tag=="papel")
                {
                    Destroy(hit.transform.gameObject);
                    spriteNota.SetActive(true);
                    Invoke("Activarpapel", 0f);
                }

                //sala2
                if (hit.transform.gameObject.tag == "palanca")
                {
                    palanca.GetComponent<Animator>().Play("SubirPalanca");
                    FindObjectOfType<levantarparedes>().subir = true;
                    FindObjectOfType<levantarparedes>().TriggerBoxes.SetActive(true);
                    FindObjectOfType<levantarparedes>().Maniquies.SetActive(true);
                }

                if (FindObjectOfType<levantarparedes>().subir == true)
                {
                    if (hit.transform.gameObject.tag == "recolectables/rec1")
                    {
                        Destroy(hit.transform.gameObject);
                        FindObjectOfType<levantarparedes>().recolectado1 = true;
                    }

                    if (hit.transform.gameObject.tag == "recolectables/rec2")
                    {
                        Destroy(hit.transform.gameObject);
                        FindObjectOfType<levantarparedes>().recolectado2 = true;
                        FindObjectOfType<levantarparedes>().pieza2 = true;
                    }

                    if (hit.transform.gameObject.tag == "recolectables/rec3")
                    {
                        Destroy(hit.transform.gameObject);
                        FindObjectOfType<levantarparedes>().recolectado3 = true;
                        FindObjectOfType<levantarparedes>().recolectado2 = true;
                    }

                    if (hit.transform.gameObject.tag == "recolectables/rec4")
                    {
                        Destroy(hit.transform.gameObject);
                        FindObjectOfType<levantarparedes>().recolectado4 = true;
                    }

                    if (FindObjectOfType<levantarparedes>().recolectado1 == true&&hit.transform.tag=="maniquibloq/1")
                    {
                         hitmaniqui1 = hit.transform.gameObject;
                        StartCoroutine(primerafase());
                    }
                    if (FindObjectOfType<levantarparedes>().recolectado2 == true && hit.transform.tag == "maniquibloq/2")
                    {
                        hitmaniqui2 = hit.transform.gameObject;
                        StartCoroutine(segundafase());
                    }
                    if (FindObjectOfType<levantarparedes>().recolectado3 == true && hit.transform.tag == "maniquibloq/3")
                    {
                        hitmaniqui3 = hit.transform.gameObject;
                        StartCoroutine(tercerafase());
                    }
                }

            }
        }
    }

    void Activarpapel()
    {
        //animacion y sonido puerta
        puerta.GetComponent<Animator>().Play("CerrarPuerta");
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxPuerta);
        //nota
        FindObjectOfType<LogicaEnemigo01>().papel = true;
        FindObjectOfType<LogicaEnemigo01>().puedemov = true;
    }
    IEnumerator primerafase()
    {
        osito.SetActive(true);
        yield return new WaitForSeconds(2f);
        hitmaniqui1.transform.gameObject.SetActive(false);
    }
    IEnumerator segundafase()
    {
        cuchillo.SetActive(true);
        yield return new WaitForSeconds(2f);
        hitmaniqui2.transform.gameObject.SetActive(false);
    }
    IEnumerator tercerafase()
    {
        mecha.SetActive(true);
        yield return new WaitForSeconds(2f);
        hitmaniqui3.transform.gameObject.SetActive(false);
    }

}
