using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public GameObject enemigo;

    //empty luces
    public GameObject lucescomp1;
    public GameObject lucescomp2;
    public GameObject lucescomp3;

    //luces P1
    public GameObject luces;
    public GameObject luces2;
    public GameObject luces3;
    public GameObject luces4;

    //luces P2
    public GameObject luces5;
    public GameObject luces6;
    public GameObject luces7;
    public GameObject luces8;

    //luces P3
    public GameObject luces9;
    public GameObject luces10;
    public GameObject luces11;
    public GameObject luces12;

    //activar enemigo
    public GameObject encuentro1;
    public GameObject encuentro2;
    public GameObject encuentro3;
    public GameObject encuentro4;

    /*//enemigo posiciones
    public GameObject pos3;
    public GameObject pos4;
    public GameObject pos5;
    public GameObject pos6;
    public GameObject pos7;*/

    //parlantes sala1
    public GameObject parlante1;
    public GameObject parlante2;
    public GameObject parlante3;

    private void OnTriggerEnter(Collider other)
    {
        //sala 2
        if (other.tag == "trigs2/encuentros")
        {
            enemigo.SetActive(true);
            other.gameObject.SetActive(false);
            
           
            if (FindObjectOfType<levantarparedes>().recolectado2 == true && FindObjectOfType<levantarparedes>().recolectado3 == false)
            {
                FindObjectOfType<triggerS2>().agent.speed = 5;
            }
            else
            {
                FindObjectOfType<triggerS2>().agent.speed = 1;
            }
        }

        if (other.tag == "collider/CP1")
        {
            StartCoroutine(LucesPuzzle1());
            parlante1.GetComponent<AudioSource>().Play();
            Destroy(other);
        }

        if (other.tag == "collider/CP2")
        {
            StartCoroutine(LucesPuzzle2());
            parlante2.GetComponent<AudioSource>().Play();
            Destroy(other);
        }

        if (other.tag == "collider/CP3")
        {
            StartCoroutine(LucesPuzzle3());
            parlante3.GetComponent<AudioSource>().Play();
            Destroy(other);
            //FindObjectOfType<LogicaEnemigo01>().enemigo.transform.position = FindObjectOfType<LogicaEnemigo01>().pos6;
        }

        if (other.tag == "collider/CP1OFF")
        {
            lucescomp1.SetActive(false);
        }
        else if (other.tag == "collider/CP2OFF")
        {
            lucescomp2.SetActive(false);
        }
        else if (other.tag == "collider/CP3OFF")
        {
            lucescomp3.SetActive(false);
            FindObjectOfType<LogicaEnemigo01>().avanzatercertrigger = true;
        }

        //enemigo colliders
        if (other.tag == "collider/CEnemigoP3")
        {
            FindObjectOfType<LogicaEnemigo01>().avanzaprimertrigger = true;
        }

        if (other.tag == "collider/CEnemigoP4")
        {
            FindObjectOfType<LogicaEnemigo01>().avanzasegundotrigger = true;
        }

        if (other.tag == "collider/CEnemigoP5")
        {
            FindObjectOfType<LogicaEnemigo01>().avanzatercertrigger = true;
        }

        if (other.tag == "collider/CEnemigoP6")
        {
            FindObjectOfType<LogicaEnemigo01>().avanzacuartotrigger = true;
        }

        if (other.tag == "collider/CEnemigoP7")
        {
            FindObjectOfType<LogicaEnemigo01>().avanzaquintotrigger = true;
        }

        //prox escena collider
        if (other.tag == "collider/CProxEsc")
        {
            SceneManager.LoadScene("Sala2");
        }

        if (other.tag == "collider/CProxEsc1")
        {
            SceneManager.LoadScene(1);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "trigs2/encuentros")
        {
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
    }

    IEnumerator LucesPuzzle1()
    {
        luces.SetActive(true);
        yield return new WaitForSeconds(1f);
        luces2.SetActive(true);
        yield return new WaitForSeconds(1f);
        luces3.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        luces4.SetActive(true);
    }

    IEnumerator LucesPuzzle2()
    {
        luces5.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        luces6.SetActive(true);
        yield return new WaitForSeconds(1f);
        luces7.SetActive(true);
        yield return new WaitForSeconds(1f);
        luces8.SetActive(true);
    }

    IEnumerator LucesPuzzle3()
    {
        luces9.SetActive(true);
        yield return new WaitForSeconds(1f);
        luces10.SetActive(true);
        yield return new WaitForSeconds(1f);
        luces11.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        luces12.SetActive(true);
    }
}
