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

    //luces pasillo
    public GameObject pasilloluz1;
    public GameObject pasilloluz2;
    public GameObject pasilloluz3;
    public GameObject pasilloluz4;
    public GameObject pasilloluz5;
    public GameObject pasilloluz6;

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

    //parlantes sala1
    public GameObject parlantePasillo;
    public GameObject parlante1;
    public GameObject parlante2;
    public GameObject parlante3;

    //parlantes sala2
    public GameObject parlante1s2;
    public GameObject parlante2s2;

    //parlantes sala3
    public GameObject parlante1s3;

    public GameObject PuertaFinal;
    public GameObject PuertaInicioSala3;
    public GameObject PuertaFinals3;
    //puerta sala 1
    public GameObject puerta;

    public GameObject piezasenemigo;

    //maniqui sala2
    public GameObject ManiquiFinal;
    public GameObject ManiquiArmario;

    //enemigo sala 3
    public GameObject Enemigos3;

    //textos ingles UI
    public GameObject textopasillos1;
    public GameObject textopuzzle1s1;
    public GameObject textopuzzle1p2s1;
    public GameObject textopuzzle2s1;
    public GameObject textopuzzle3s1;

    public GameObject textoentradas2;
    public GameObject textosalidas2;

    public GameObject textoentradas3;

    //puerta sala 4
    public GameObject PuertaFS4;


    private void OnTriggerEnter(Collider other)
    {
        //sala4
        if (other.tag == "trigs4/colliderteleportpared")
        {
            FindObjectOfType<Logica_Enemigo4>().teleportPared1 = true;
            Destroy(other);
        }

        if (other.tag == "trigs4/colliderteleportpared2")
        {
            FindObjectOfType<Logica_Enemigo4>().teleportPared2 = true;
            Destroy(other);
        }

        if (other.tag == "trigs4/colliderteleportpared3")
        {
            //sonidos puertas golpeadas
            Invoke("AbrirPuertaFS4", 17f);
            FindObjectOfType<Logica_Enemigo4>().teleportPared3 = true;
            Destroy(other);
        }

        //sala3

        if (other.tag == "trigs3/colliderinicio1")
        {
            FindObjectOfType<puzzlesala3>().c1activo = true;
            Destroy(other);
        }

        if (other.tag == "trigs3/colliderinicio2")
        {
            FindObjectOfType<puzzlesala3>().c2activo = true;
            Destroy(other);
        }

        if (other.tag == "trigs3/colliderinicio3")
        {
            FindObjectOfType<puzzlesala3>().c3activo = true;
            Destroy(other);
        }

        if (other.tag == "trigs3/voz")
        {
            parlante1s3.GetComponent<AudioSource>().Play();
            StartCoroutine(MostrarTxtEntradaS3());
            PuertaInicioSala3.GetComponent<Animator>().Play("CerrarPuerta");
            Destroy(other);
        }

        if (other.tag == "trigs3/salida")
        {
            PuertaFinals3.GetComponent<Animator>().Play("CerrarPuertaF");
            PuertaFinals3.GetComponent<AudioSource>().Play();
            Enemigos3.SetActive(false);
            //logro 3
            logrosManager.triggerLogro03 = true;
            Destroy(other);
        }

        if (other.tag == "trigs3/proxesc")
        {
            Invoke("EscenitaS4", 0f);
        }

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

        if (other.tag == "trigs2/animacion")
        {
            ManiquiFinal.SetActive(true);
            ManiquiFinal.GetComponent<Animator>().Play("Caida");
        }

        if (other.tag == "trigs2/animacionArmario")
        {
            ManiquiArmario.GetComponent<Animator>().Play("Asomado");
        }

        if (other.tag == "trigs2/vozsalida")
        {
            parlante2s2.GetComponent<AudioSource>().Play();
            StartCoroutine(MostrarTxtSalidaS2());
            Destroy(other);
        }

        if (other.tag == "trigs2/salida")
        {
            PuertaFinal.GetComponent<Animator>().Play("CerrarPuertaF");
            PuertaFinal.GetComponent<AudioSource>().Play();
            //sonido de los golpes
            //logro 2
            logrosManager.triggerLogro02 = true;
            Destroy(other);
        }

        if (other.tag == "trigs2/voz")
        {
            parlante1s2.GetComponent<AudioSource>().Play();
            StartCoroutine(MostrarTxtEntradaS2());
            Destroy(other);
        }

        if (other.tag == "trigs2/CProxEsc3")
        {
            Invoke("EscenitaS3", 0f);
        }

        if (other.tag == "collider/vozpasillos1")
        {
            parlantePasillo.GetComponent<AudioSource>().Play();
            StartCoroutine(MostrarTxtPasillo());
            Destroy(other);
        }

        if (other.tag == "collider/puertaS1")
        {
            //animacion y sonido puerta
            puerta.GetComponent<Animator>().Play("CerrarPuerta");
            sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxPuerta);
        }

        if (other.tag == "collider/CLI")
        {
            StartCoroutine(LucesPasillo());
        }

        if (other.tag == "collider/CP1")
        {
            StartCoroutine(LucesPuzzle1());
            parlante1.GetComponent<AudioSource>().Play();
            StartCoroutine(MostrarTxtPuzzle1());
            piezasenemigo.SetActive(false);
            Destroy(other);
        }

        if (other.tag == "collider/CP2")
        {
            StartCoroutine(LucesPuzzle2());
            parlante2.GetComponent<AudioSource>().Play();
            StartCoroutine(MostrarTxtPuzzle2());
            Destroy(other);
        }

        if (other.tag == "collider/CP3")
        {
            StartCoroutine(LucesPuzzle3());
            parlante3.GetComponent<AudioSource>().Play();
            StartCoroutine(MostrarTxtPuzzle3());
            Destroy(other);
            //FindObjectOfType<LogicaEnemigo01>().enemigo.transform.position = FindObjectOfType<LogicaEnemigo01>().pos6;
        }

        if (other.tag == "collider/CP1OFF")
        {
            lucescomp1.SetActive(false);
            if (FindObjectOfType<Agarrar>().spriteNota)
            {
                FindObjectOfType<Agarrar>().spriteNota.SetActive(false);
            }
        }
        else if (other.tag == "collider/CP2OFF")
        {
            lucescomp2.SetActive(false);
        }
        else if (other.tag == "collider/CP3OFF")
        {
            lucescomp3.SetActive(false);
            //logro 1
            logrosManager.triggerLogro01 = true;
            FindObjectOfType<LogicaEnemigo01>().avanzatercertrigger = true;
        }

        //enemigo colliders
        if (other.tag == "collider/CEnemigoP3")
        {
            FindObjectOfType<LogicaEnemigo01>().avanzaprimertrigger = true;
            FindObjectOfType<LogicaEnemigo01>().sonidito = true;
            Destroy(other.gameObject);
        }

        if (other.tag == "collider/CEnemigoP4")
        {
            FindObjectOfType<LogicaEnemigo01>().avanzasegundotrigger = true;
            FindObjectOfType<LogicaEnemigo01>().sonidito = true;
            Destroy(other.gameObject);
        }

        if (other.tag == "collider/CEnemigoP5")
        {
            FindObjectOfType<LogicaEnemigo01>().avanzatercertrigger = true;
            FindObjectOfType<LogicaEnemigo01>().sonidito = true;
            Destroy(other.gameObject);
        }

        if (other.tag == "collider/CEnemigoP6")
        {
            FindObjectOfType<LogicaEnemigo01>().avanzacuartotrigger = true;
            FindObjectOfType<LogicaEnemigo01>().sonidito = true;
            Destroy(other.gameObject);
        }

        if (other.tag == "collider/CEnemigoP7")
        {
            FindObjectOfType<LogicaEnemigo01>().avanzaquintotrigger = true;
            FindObjectOfType<LogicaEnemigo01>().sonidito = true;
            Destroy(other.gameObject);
        }

        //prox escena collider

        if (other.tag == "collider/CProxEsc1")
        {
            Debug.Log("toque collider pa cambiar de sala a la 1");
            Invoke("EscenitaS1", 0f);
        }

        if (other.tag == "collider/CProxEsc")
        {
            Debug.Log("toque collider pa cambiar de sala a la 2");
            Invoke("EscenitaS2", 0f);
        }
    }

    public void EscenitaS1()
    {
        CambiarEscena1("Sala 1");
    }

    public void CambiarEscena1(string nombreEscena)
    {
        nivelesManager.instance.LoadScene(nombreEscena);
    }

    public void EscenitaS2()
    {
        CambiarEscena2("Sala2");
    }

    public void CambiarEscena2(string nombreEscena)
    {
        nivelesManager.instance.LoadScene(nombreEscena);
    }

    public void EscenitaS3()
    {
        CambiarEscena3("Sala 3");
    }

    public void CambiarEscena3(string nombreEscena)
    {
        nivelesManager.instance.LoadScene(nombreEscena);
    }

    public void EscenitaS4()
    {
        CambiarEscena4("Sala 4");
    }

    public void CambiarEscena4(string nombreEscena)
    {
        nivelesManager.instance.LoadScene(nombreEscena);
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "trigs2/encuentros")
        {
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
    }

    public void AbrirPuertaFS4()
    {
        PuertaFS4.GetComponent<Animator>().Play("AbrirPuerta");
    }
    IEnumerator LucesPasillo()
    {
        yield return new WaitForSeconds(0.2f);
        pasilloluz1.SetActive(true);
        yield return new WaitForSeconds(1f);
        pasilloluz2.SetActive(true);
        yield return new WaitForSeconds(1f);
        pasilloluz3.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        pasilloluz4.SetActive(true);
        yield return new WaitForSeconds(1f);
        pasilloluz5.SetActive(true);
        yield return new WaitForSeconds(1f);
        pasilloluz6.SetActive(true);
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

    IEnumerator MostrarTxtPasillo()
    {
        textopasillos1.SetActive(true);
        yield return new WaitForSeconds(12f);
        textopasillos1.SetActive(false);
    }

    IEnumerator MostrarTxtPuzzle1()
    {
        textopuzzle1s1.SetActive(true); 
        yield return new WaitForSeconds(11f);
        textopuzzle1s1.SetActive(false);
        textopuzzle1p2s1.SetActive(true);
        yield return new WaitForSeconds(9f);
        textopuzzle1p2s1.SetActive(false);
    }

    IEnumerator MostrarTxtPuzzle2()
    {
        textopuzzle2s1.SetActive(true);
        yield return new WaitForSeconds(10f);
        textopuzzle2s1.SetActive(false);
    }

    IEnumerator MostrarTxtPuzzle3()
    {
        textopuzzle3s1.SetActive(true);
        yield return new WaitForSeconds(11f);
        textopuzzle3s1.SetActive(false);
    }

    IEnumerator MostrarTxtEntradaS2()
    {
        textoentradas2.SetActive(true);
        yield return new WaitForSeconds(26f);
        textoentradas2.SetActive(false);
    }

    IEnumerator MostrarTxtSalidaS2()
    {
        textosalidas2.SetActive(true);
        yield return new WaitForSeconds(21f);
        textosalidas2.SetActive(false);
    }

    IEnumerator MostrarTxtEntradaS3()
    {
        yield return new WaitForSeconds(1f);
        textoentradas3.SetActive(true);
        yield return new WaitForSeconds(16f);
        textoentradas3.SetActive(false);
    }
}
