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
    public static int logro01Contador;
    public int logro01Trigger = 1;
    public int logro01Codigo;

    void Start()
    {
        PlayerPrefs.DeleteKey("logro01");
    }

    // Update is called once per frame
    void Update()
    {
        logro01Codigo = PlayerPrefs.GetInt("logro01");
        if (logro01Contador == logro01Trigger && logro01Codigo != 12)
        {
            StartCoroutine(TriggerLogro01());
        }
    }

    IEnumerator TriggerLogro01()
    {
        logroActivo = true;
        logro01Codigo = 12;
        PlayerPrefs.SetInt("logro01", logro01Codigo);
        //logroSonido.Play();
        logro01Img.SetActive(true);
        logroTitulo.GetComponent<TextMeshProUGUI>().text = "LOGRO 1 CAPO";
        logroDescripcion.GetComponent<TextMeshProUGUI>().text = "DESCRIP LOGRO 1";
        logroNota.SetActive(true);
        yield return new WaitForSeconds(7);

        //Reset
        logroNota.SetActive(false);
        logro01Img.SetActive(false);
        logroTitulo.GetComponent<TextMeshProUGUI>().text = "";
        logroDescripcion.GetComponent<TextMeshProUGUI>().text = "";
        logroActivo = false;
    }
}
