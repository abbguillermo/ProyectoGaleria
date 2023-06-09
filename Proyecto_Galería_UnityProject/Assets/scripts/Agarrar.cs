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

    public GameObject spriteNota;


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
                    puerta.SetActive(true);
                    //se reproduce el sonido de puerta
                    sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxPuerta);
                    spriteNota.SetActive(true);
                   // ui.papel.Setactive(true);
                    Invoke("Activarpapel", 4f);
                }
            }

            
        }
    }

    void Activarpapel()
    {
        
        FindObjectOfType<LogicaEnemigo01>().papel = true;
        FindObjectOfType<LogicaEnemigo01>().puedemov = true;
    }

    
}
