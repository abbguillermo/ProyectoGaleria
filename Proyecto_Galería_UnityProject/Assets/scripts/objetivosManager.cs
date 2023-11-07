using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class objetivosManager : MonoBehaviour
{
    //Variables generales
    public GameObject objetivoPanel;
    //public AudioSource objetivoSonido;
    public bool objetivoActivo = false;
    public GameObject objetivoDescripcion;

    public GameObject objetivo1Descrip;
    public GameObject objetivo2Descrip;
    public GameObject objetivo3Descrip;


    //Obj 1 SALA1
    public static bool triggerObjetivo01 = false;
    public int objetivo01Codigo;
    public static bool objetivo01Complete = false;

    //Obj 2 SALA1
    public static bool triggerObjetivo02 = false;
    public int objetivo02Codigo;
    public static bool objetivo02Complete = false;

    //Obj 3 SALA1
    public static bool triggerObjetivo03 = false;
    public int objetivo03Codigo;
    public static bool objetivo03Complete = false;

    //Obj 1 SALA2
    public static bool triggerObjetivo01S2 = false;
    public int objetivo01S2Codigo;
    public static bool objetivo01S2Complete = false;


    private void Start()
    {
        if (!objetivo01Complete || !objetivo02Complete || !objetivo03Complete || !objetivo01S2Complete)
        {
            triggerObjetivo01 = false;
            triggerObjetivo02 = false;
            triggerObjetivo03 = false;
            triggerObjetivo01S2 = false;
        }
    }

    void Update()
    {

        if (triggerObjetivo01 == true && objetivo01Codigo != 12)
        {
            StartCoroutine(TriggerObjetivo01());
        }

        if (triggerObjetivo02 == true && objetivo02Codigo != 13)
        {
            StartCoroutine(TriggerObjetivo02());
        }

        if (triggerObjetivo03 == true && objetivo03Codigo != 14)
        {
            StartCoroutine(TriggerObjetivo03());
        }

        if (triggerObjetivo01S2 == true && objetivo01S2Codigo != 15)
        {
            StartCoroutine(TriggerObjetivo01S2());
        }

        if (objetivo01Complete)
        {
            //Reset
            objetivoPanel.transform.LeanMoveLocal(new Vector2(-700, 190), 1).setEaseOutSine();
            objetivoPanel.SetActive(false);
            objetivo1Descrip.GetComponent<TextMeshProUGUI>().text = "";
            objetivo1Descrip.SetActive(false);
            objetivoActivo = false;
            triggerObjetivo01 = false;
            objetivo01Complete = false;
        }

        if (objetivo02Complete)
        {
            //Reset
            objetivoPanel.transform.LeanMoveLocal(new Vector2(-700, 190), 1).setEaseOutSine();
            objetivoPanel.SetActive(false);
            objetivo2Descrip.GetComponent<TextMeshProUGUI>().text = "";
            objetivo2Descrip.SetActive(false);
            objetivoActivo = false;
            triggerObjetivo02 = false;
            objetivo02Complete = false;
        }

        if (objetivo03Complete)
        {
            //Reset
            objetivoPanel.transform.LeanMoveLocal(new Vector2(-700, 190), 1).setEaseOutSine();
            objetivoPanel.SetActive(false);
            objetivo3Descrip.GetComponent<TextMeshProUGUI>().text = "";
            objetivo3Descrip.SetActive(false);
            objetivoActivo = false;
            triggerObjetivo03 = false;
            objetivo03Complete = false;
        }

        if (objetivo01S2Complete)
        {
            //Reset
            objetivoPanel.transform.LeanMoveLocal(new Vector2(-700, 190), 1).setEaseOutSine();
            objetivoPanel.SetActive(false);
            objetivoDescripcion.GetComponent<TextMeshProUGUI>().text = "";
            objetivoActivo = false;
            triggerObjetivo01S2 = false;
            objetivo01S2Complete = false;
        }
    }

    IEnumerator TriggerObjetivo01()
    {
        objetivoActivo = true;
        objetivo01Codigo = 12;
        //objetivoSonido.Play();
        objetivo1Descrip.GetComponent<TextMeshProUGUI>().text = "Use su CABEZA";
        objetivoPanel.SetActive(true);
        objetivoPanel.transform.LeanMoveLocal(new Vector2(-370, 190), 1).setEaseOutSine();
        yield return new WaitForSeconds(0);
    }

    IEnumerator TriggerObjetivo02()
    {
        objetivo1Descrip.SetActive(false);
        objetivo3Descrip.SetActive(false);
        objetivo2Descrip.SetActive(true);
        objetivoActivo = true;
        objetivo02Codigo = 13;
        //objetivoSonido.Play();
        objetivo2Descrip.GetComponent<TextMeshProUGUI>().text = "Ellos APUNTAN hacia mi objetivo";
        objetivoPanel.SetActive(true);
        objetivoPanel.transform.LeanMoveLocal(new Vector2(-370, 190), 1).setEaseOutSine();
        yield return new WaitForSeconds(0);
    }

    IEnumerator TriggerObjetivo03()
    {
        objetivo3Descrip.SetActive(true);
        objetivo1Descrip.SetActive(false);
        objetivo2Descrip.SetActive(false);
        objetivoActivo = true;
        objetivo03Codigo = 14;
        //objetivoSonido.Play();
        objetivo3Descrip.GetComponent<TextMeshProUGUI>().text = "La mente de un NIÑO";
        objetivoPanel.SetActive(true);
        objetivoPanel.transform.LeanMoveLocal(new Vector2(-370, 190), 1).setEaseOutSine();
        yield return new WaitForSeconds(0);
    }

    IEnumerator TriggerObjetivo01S2()
    {
        objetivoActivo = true;
        objetivo01S2Codigo = 15;
        //objetivoSonido.Play();
        objetivoDescripcion.GetComponent<TextMeshProUGUI>().text = "Encuentre la PALANCA";
        //objetivoPanel.SetActive(true);
        objetivoPanel.transform.LeanMoveLocal(new Vector2(-370, 190), 1).setEaseOutSine();
        yield return new WaitForSeconds(0);
    }
}
