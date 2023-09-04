using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;


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
    public bool puedeagarrar=true;
    public bool puedeagarrar2 = true;
    public GameObject escondite1_sala2;
    public GameObject spriteNota;
    public GameObject palanca;
    public GameObject osito;
    public GameObject cuchillo;
    public GameObject mecha;
    private GameObject hitmaniqui1;
    private GameObject hitmaniqui2;
    private GameObject hitmaniqui3;

    public GameObject spriteOsito;
    public GameObject spriteOsitoSilueta;
    public GameObject spriteCuchillo;
    public GameObject spriteCuchilloSilueta;
    public GameObject spriteEncendedor;
    public GameObject spriteEncendedorSilueta;

    //Objetos sala inicial
    public GameObject radio;
    public GameObject cuadro;
    public GameObject personaje;

    public AudioSource audioSourceRadio;
    public AudioSource audioSourceQuejidos;

    public Volume m_Volume;
    public ColorAdjustments ca;

    public ControlScroll mano;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(puedeagarrar2);
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
               
                //SALA3
                if (puedeagarrar2==true)
                {
                    if (hit.transform.gameObject.tag == "Sala3/objeto1"|| hit.transform.gameObject.tag == "Sala3/objeto2"|| hit.transform.gameObject.tag == "Sala3/objeto3"|| hit.transform.gameObject.tag == "Sala3/objeto4"|| hit.transform.gameObject.tag == "Sala3/objeto5"|| hit.transform.gameObject.tag == "Sala3/objeto6")
                    {
                        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxObjetoS2);
                        GameObject objeto = hit.transform.gameObject;

                        objeto.transform.SetParent(puntodeagarre);
                        objeto.transform.localPosition = Vector3.zero;
                        objeto.transform.localRotation = Quaternion.identity;
                        puedeagarrar2 = false;
                    }
                }

                if(puedeagarrar2==false&&(hit.transform.gameObject.tag == "Sala3/objeto1" || hit.transform.gameObject.tag == "Sala3/objeto2" || hit.transform.gameObject.tag == "Sala3/objeto3" || hit.transform.gameObject.tag == "Sala3/objeto4" || hit.transform.gameObject.tag == "Sala3/objeto5" || hit.transform.gameObject.tag == "Sala3/objeto6"))
                {
                    sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxObjetoS2);
                    GameObject.FindGameObjectWithTag("mano").gameObject.transform.GetChild(0);

                    GameObject.FindGameObjectWithTag("mano").gameObject.transform.GetChild(0).gameObject.transform.position = new Vector3(hit.transform.position.x, hit.transform.position.y, hit.transform.position.z);
                    GameObject.FindGameObjectWithTag("mano").gameObject.transform.GetChild(0).gameObject.transform.rotation = marcorot;
                    GameObject.FindGameObjectWithTag("mano").gameObject.transform.GetChild(0).SetParent(null);
                    hit.transform.SetParent(puntodeagarre);
                    hit.transform.localPosition = Vector3.zero;
                    hit.transform.localRotation = Quaternion.identity;
                    puedeagarrar2 = false;
                }

                if (hit.transform.gameObject.tag == "Sala3/atril1")
                {
                   
                   
                    GameObject.FindGameObjectWithTag("mano").gameObject.transform.GetChild(0);

                    GameObject.FindGameObjectWithTag("mano").gameObject.transform.GetChild(0).gameObject.transform.position = new Vector3(hit.transform.position.x, hit.transform.position.y, hit.transform.position.z);
                    GameObject.FindGameObjectWithTag("mano").gameObject.transform.GetChild(0).gameObject.transform.rotation = marcorot;
                    GameObject.FindGameObjectWithTag("mano").gameObject.transform.GetChild(0).SetParent(null);
                    puedeagarrar2 = true;
                }
                
               


                //sala inicial
                if (hit.transform.gameObject.tag == "salainicial/radio")
                {
                    audioSourceRadio.Play();
                    audioSourceQuejidos.Play();
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
             
                    hit.transform.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                    escondite1_sala2.SetActive(false);
                    FindObjectOfType<Logicaenemigo_sala2>().puedeatacar = false;
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
                    sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxObjetoS2);
                }

              


                //sala2
                if (hit.transform.gameObject.tag == "palanca")
                {
                    palanca.GetComponent<Animator>().Play("SubirPalanca");
                    FindObjectOfType<levantarparedes>().subir = true;
                    FindObjectOfType<levantarparedes>().TriggerBoxes.SetActive(true);
                    FindObjectOfType<levantarparedes>().Maniquies.SetActive(true);
                }

                if (FindObjectOfType<levantarparedes>().recolectables == true)
                {
                    if (hit.transform.gameObject.tag == "recolectables/rec1")
                    {
                        Destroy(hit.transform.gameObject);
                        FindObjectOfType<levantarparedes>().recolectado1 = true;
                        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxObjetoS2);
                        spriteOsitoSilueta.SetActive(false);
                        spriteOsito.SetActive(true);
                    }

                    if (hit.transform.gameObject.tag == "recolectables/rec2")
                    {
                        Destroy(hit.transform.gameObject);
                        FindObjectOfType<levantarparedes>().recolectado2 = true;
                        FindObjectOfType<levantarparedes>().pieza2 = true;
                        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxObjetoS2);
                        spriteCuchilloSilueta.SetActive(false);
                        spriteCuchillo.SetActive(true);
                    }

                    if (hit.transform.gameObject.tag == "recolectables/rec3")
                    {
                        Destroy(hit.transform.gameObject);
                        FindObjectOfType<levantarparedes>().recolectado3 = true;
                        FindObjectOfType<levantarparedes>().recolectado2 = true;
                        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxObjetoS2);
                        spriteEncendedorSilueta.SetActive(false);
                        spriteEncendedor.SetActive(true);
                    }

                    /*if (hit.transform.gameObject.tag == "recolectables/rec4")
                    {
                        Destroy(hit.transform.gameObject);
                        FindObjectOfType<levantarparedes>().recolectado4 = true;
                    }*/

                    if (FindObjectOfType<levantarparedes>().recolectado1 == true&&hit.transform.tag=="maniquibloq/1")
                    {
                        hitmaniqui1 = hit.transform.gameObject;
                        spriteOsito.SetActive(false);
                        m_Volume.profile.TryGet(out ca);
                        if (ca.postExposure.value > -5f)
                        {
                            StartCoroutine(bajarExposure());
                        }
                        StartCoroutine(primerafase());
                    }
                    else if (FindObjectOfType<levantarparedes>().recolectado1 == false && hit.transform.tag == "maniquibloq/1")
                    {
                        hitmaniqui1 = hit.transform.gameObject;
                        spriteOsitoSilueta.SetActive(true);
                    }

                    if (FindObjectOfType<levantarparedes>().recolectado2 == true && hit.transform.tag == "maniquibloq/2")
                    {
                        hitmaniqui2 = hit.transform.gameObject;
                        spriteCuchillo.SetActive(false);
                        m_Volume.profile.TryGet(out ca);
                        if (ca.postExposure.value > -5f)
                        {
                            StartCoroutine(bajarExposure());
                        }
                        StartCoroutine(segundafase());
                    }
                    else if (FindObjectOfType<levantarparedes>().recolectado2 == false && hit.transform.tag == "maniquibloq/2")
                    {
                        hitmaniqui2 = hit.transform.gameObject;
                        spriteCuchilloSilueta.SetActive(true);
                    }

                    if (FindObjectOfType<levantarparedes>().recolectado3 == true && hit.transform.tag == "maniquibloq/3")
                    {
                        hitmaniqui3 = hit.transform.gameObject;
                        spriteEncendedor.SetActive(false);
                        m_Volume.profile.TryGet(out ca);
                        if (ca.postExposure.value > -5f)
                        {
                            StartCoroutine(bajarExposure());
                        }
                        StartCoroutine(tercerafase());
                    }
                    else if (FindObjectOfType<levantarparedes>().recolectado3 == false && hit.transform.tag == "maniquibloq/3")
                    {
                        hitmaniqui3 = hit.transform.gameObject;
                        spriteEncendedorSilueta.SetActive(true);
                    }
                }
              
            }
        }
    }

    void Activarpapel()
    {
        //nota
        FindObjectOfType<LogicaEnemigo01>().papel = true;
        FindObjectOfType<LogicaEnemigo01>().puedemov = true;
    }
    IEnumerator primerafase()
    {
        osito.SetActive(true);
        yield return new WaitForSeconds(2f);
        hitmaniqui1.transform.gameObject.SetActive(false);
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxDesaparicionManiquies);
        m_Volume.profile.TryGet(out ca);
        ca.postExposure.value = 2.5f;
    }
    IEnumerator segundafase()
    {
        cuchillo.SetActive(true);
        yield return new WaitForSeconds(2f);
        hitmaniqui2.transform.gameObject.SetActive(false);
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxDesaparicionManiquies);
        m_Volume.profile.TryGet(out ca);
        ca.postExposure.value = 2.5f;
    }
    IEnumerator tercerafase()
    {
        mecha.SetActive(true);
        yield return new WaitForSeconds(2f);
        hitmaniqui3.transform.gameObject.SetActive(false);
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxDesaparicionManiquies);
        m_Volume.profile.TryGet(out ca);
        ca.postExposure.value = 2.5f;
    }

    IEnumerator bajarExposure()
    {
        ca.postExposure.value -= 0.5f;
        yield return new WaitForSeconds(0.01f);
        ca.postExposure.value -= 0.5f;
        yield return new WaitForSeconds(0.01f);
        ca.postExposure.value -= 0.5f;
        yield return new WaitForSeconds(0.01f);
        ca.postExposure.value -= 0.5f;
        yield return new WaitForSeconds(0.01f);
        ca.postExposure.value -= 0.5f;
        yield return new WaitForSeconds(0.01f);
        ca.postExposure.value -= 0.5f;
        yield return new WaitForSeconds(0.01f);
        ca.postExposure.value -= 0.5f;
        yield return new WaitForSeconds(0.01f);
        ca.postExposure.value -= 0.5f;
        yield return new WaitForSeconds(0.01f);
        ca.postExposure.value -= 0.5f;
        yield return new WaitForSeconds(0.01f);
        ca.postExposure.value -= 0.5f;
        yield return new WaitForSeconds(0.01f);
        ca.postExposure.value -= 0.5f;
        yield return new WaitForSeconds(0.01f);
        ca.postExposure.value -= 0.5f;
        yield return new WaitForSeconds(0.01f);
        ca.postExposure.value -= 0.5f;
        yield return new WaitForSeconds(0.01f);
        ca.postExposure.value -= 0.5f;
        yield return new WaitForSeconds(0.01f);
        ca.postExposure.value -= 0.5f;
    }

}
