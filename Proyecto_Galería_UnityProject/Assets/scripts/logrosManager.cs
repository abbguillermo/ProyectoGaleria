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


    //Logro 1
    public GameObject logro01Img;
    public static bool triggerLogro01 = false;
    public int logro01Codigo;

    //Logro 2
    public GameObject logro02Img;
    public static bool triggerLogro02= false;
    public int logro02Codigo;
    /*
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
    public int logro06Codigo; */

    void Start()
    {
        PlayerPrefs.DeleteKey("logro01");
    }

    // Update is called once per frame
    void Update()
    {
        logro01Codigo = PlayerPrefs.GetInt("logro01");
        logro02Codigo = PlayerPrefs.GetInt("logro02");

        if (triggerLogro01 == true && logro01Codigo != 12)
        {
            StartCoroutine(TriggerLogro01());
        }

        if (triggerLogro02 == true && logro02Codigo != 13)
        {
            StartCoroutine(TriggerLogro02());
        }
    }

    IEnumerator TriggerLogro01()
    {
        logroActivo = true;
        logro01Codigo = 12;
        PlayerPrefs.SetInt("logro01", logro01Codigo);
        //logroSonido.Play();
        logro01Img.SetActive(true);
        logroTitulo.GetComponent<TextMeshProUGUI>().text = "Logro desbloqueado";
        logroDescripcion.GetComponent<TextMeshProUGUI>().text = "Completar sala 1";
        logroNota.SetActive(true);
        yield return new WaitForSeconds(7);

        //Reset
        logroNota.SetActive(false);
        logro01Img.SetActive(false);
        logroTitulo.GetComponent<TextMeshProUGUI>().text = "";
        logroDescripcion.GetComponent<TextMeshProUGUI>().text = "";
        logroActivo = false;

        triggerLogro01 = false;
    }

    IEnumerator TriggerLogro02()
    {
        logroActivo = true;
        logro01Codigo = 13;
        PlayerPrefs.SetInt("logro02", logro02Codigo);
        //logroSonido.Play();
        logro02Img.SetActive(true);
        logroTitulo.GetComponent<TextMeshProUGUI>().text = "Logro desbloqueado";
        logroDescripcion.GetComponent<TextMeshProUGUI>().text = "Completar sala 2";
        logroNota.SetActive(true);
        yield return new WaitForSeconds(7);

        //Reset
        logroNota.SetActive(false);
        logro02Img.SetActive(false);
        logroTitulo.GetComponent<TextMeshProUGUI>().text = "";
        logroDescripcion.GetComponent<TextMeshProUGUI>().text = "";
        logroActivo = false;

        triggerLogro02 = false;
    }
}
