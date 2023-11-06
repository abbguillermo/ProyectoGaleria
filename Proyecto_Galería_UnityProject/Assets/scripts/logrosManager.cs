using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class logrosManager : MonoBehaviour
{
    //Variables generales
    public GameObject logroNota;
    //public AudioSource logroSonido;
    public bool logroActivo = false;
    public GameObject logroTitulo;
    public GameObject logroDescripcion;

    public GameObject logroDescripcionAch6;


    //Logro 1
    public GameObject logro01Img;
    public static bool triggerLogro01 = false;
    public int logro01Codigo;

    //Logro 2
    public GameObject logro02Img;
    public static bool triggerLogro02= false;
    public int logro02Codigo;

    //Logro 3
    public GameObject logro03Img;
    public static bool triggerLogro03 = false;
    public int logro03Codigo;

    //Logro 4
    public GameObject logro04Img;
    public static bool triggerLogro04 = false;
    public int logro04Codigo;
    
    //Logro 5
    public GameObject logro05Img;
    public static bool triggerLogro05 = false;
    public int logro05Codigo;
    
    //Logro 6
    public GameObject logro06Img;
    public static bool triggerLogro06 = false;
    public int logro06Codigo;

    void Start()
    {
        PlayerPrefs.DeleteKey("activarlogro01");
    }

    void Update()
    {
        //logro01Codigo = PlayerPrefs.GetInt("logro01");
        //logro02Codigo = PlayerPrefs.GetInt("logro02");

        if (triggerLogro01 == true && logro01Codigo != 12)
        {
            StartCoroutine(TriggerLogro01());
        }

        if (triggerLogro02 == true && logro02Codigo != 13)
        {
            StartCoroutine(TriggerLogro02());
        }

        if (triggerLogro03 == true && logro03Codigo != 14)
        {
            StartCoroutine(TriggerLogro03());
        }

        if (triggerLogro04 == true && logro04Codigo != 15)
        {
            StartCoroutine(TriggerLogro04());
        }

        if (triggerLogro05 == true && logro05Codigo != 16)
        {
            StartCoroutine(TriggerLogro05());
        }

        if (triggerLogro06 == true && logro06Codigo != 17)
        {
            StartCoroutine(TriggerLogro06());
        }
    }

    IEnumerator TriggerLogro01()
    {
        logroActivo = true;
        logro01Codigo = 12;
        //PlayerPrefs.SetInt("logro01", logro01Codigo);
        //logroSonido.Play();
        logro01Img.SetActive(true);
        logroTitulo.GetComponent<TextMeshProUGUI>().text = "Logro desbloqueado";
        logroDescripcion.GetComponent<TextMeshProUGUI>().text = "Completar sala 1";
        logroNota.SetActive(true);
        PlayerPrefs.SetInt("activarlogro01", 1);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(3);

        //Reset
        logroNota.SetActive(false);
        logro01Img.SetActive(false);
        logroTitulo.GetComponent<TextMeshProUGUI>().text = "";
        logroDescripcion.GetComponent<TextMeshProUGUI>().text = "";
        logroDescripcionAch6.GetComponent<TextMeshProUGUI>().text = "";
        logroActivo = false;

        triggerLogro01 = false;
    }

    IEnumerator TriggerLogro02()
    {
        logroActivo = true;
        logro02Codigo = 13;
        //PlayerPrefs.SetInt("logro02", logro02Codigo);
        //logroSonido.Play();
        logro02Img.SetActive(true);
        logroTitulo.GetComponent<TextMeshProUGUI>().text = "Logro desbloqueado";
        logroDescripcion.GetComponent<TextMeshProUGUI>().text = "Completar sala 2";
        logroNota.SetActive(true);
        yield return new WaitForSeconds(3);

        //Reset
        logroNota.SetActive(false);
        logro02Img.SetActive(false);
        logroTitulo.GetComponent<TextMeshProUGUI>().text = "";
        logroDescripcion.GetComponent<TextMeshProUGUI>().text = "";
        logroDescripcionAch6.GetComponent<TextMeshProUGUI>().text = "";
        logroActivo = false;

        triggerLogro02 = false;
    }

    IEnumerator TriggerLogro03()
    {
        logroActivo = true;
        logro03Codigo = 14;
        //PlayerPrefs.SetInt("logro02", logro02Codigo);
        //logroSonido.Play();
        logro03Img.SetActive(true);
        logroTitulo.GetComponent<TextMeshProUGUI>().text = "Logro desbloqueado";
        logroDescripcion.GetComponent<TextMeshProUGUI>().text = "Completar sala 3";
        logroNota.SetActive(true);
        yield return new WaitForSeconds(3);

        //Reset
        logroNota.SetActive(false);
        logro03Img.SetActive(false);
        logroTitulo.GetComponent<TextMeshProUGUI>().text = "";
        logroDescripcion.GetComponent<TextMeshProUGUI>().text = "";
        logroDescripcionAch6.GetComponent<TextMeshProUGUI>().text = "";
        logroActivo = false;

        triggerLogro03 = false;
    }

    IEnumerator TriggerLogro04()
    {
        logroActivo = true;
        logro04Codigo = 15;
        //logroSonido.Play();
        logro04Img.SetActive(true);
        logroTitulo.GetComponent<TextMeshProUGUI>().text = "Logro desbloqueado";
        logroDescripcion.GetComponent<TextMeshProUGUI>().text = "Completar sala 4";
        logroNota.SetActive(true);
        yield return new WaitForSeconds(3);

        //Reset
        logroNota.SetActive(false);
        logro04Img.SetActive(false);
        logroTitulo.GetComponent<TextMeshProUGUI>().text = "";
        logroDescripcion.GetComponent<TextMeshProUGUI>().text = "";
        logroDescripcionAch6.GetComponent<TextMeshProUGUI>().text = "";
        logroActivo = false;

        triggerLogro04 = false;
    }
    IEnumerator TriggerLogro05()
    {
        logroActivo = true;
        logro05Codigo = 16;
        //logroSonido.Play();
        logro05Img.SetActive(true);
        logroTitulo.GetComponent<TextMeshProUGUI>().text = "Logro desbloqueado";
        logroDescripcion.GetComponent<TextMeshProUGUI>().text = "Escondite";
        logroNota.SetActive(true);
        yield return new WaitForSeconds(3);

        //Reset
        logroNota.SetActive(false);
        logro05Img.SetActive(false);
        logroTitulo.GetComponent<TextMeshProUGUI>().text = "";
        logroDescripcion.GetComponent<TextMeshProUGUI>().text = "";
        logroDescripcionAch6.GetComponent<TextMeshProUGUI>().text = "";
        logroActivo = false;

        triggerLogro05 = false;
        Destroy(this);
    }

    IEnumerator TriggerLogro06()
    {
        logroActivo = true;
        logro06Codigo = 17;
        //logroSonido.Play();
        logro06Img.SetActive(true);
        logroTitulo.GetComponent<TextMeshProUGUI>().text = "Logro desbloqueado";
        logroDescripcion.SetActive(false);
        logroDescripcionAch6.GetComponent<TextMeshProUGUI>().text = "HOLA";

        logroNota.SetActive(true);
        yield return new WaitForSeconds(3);

        //Reset
        logroNota.SetActive(false);
        logro06Img.SetActive(false);
        logroTitulo.GetComponent<TextMeshProUGUI>().text = "";
        logroDescripcion.GetComponent<TextMeshProUGUI>().text = "";
        logroDescripcion.SetActive(true);
        logroDescripcionAch6.SetActive(false);
        logroActivo = false;

        triggerLogro06 = false;
    }
}
