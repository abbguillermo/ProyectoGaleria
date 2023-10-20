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


    //Logro 1
    public static bool triggerObjetivo01 = false;
    public int objetivo01Codigo;
    public static bool objetivo01Complete = false;

    //Logro 2
    public static bool triggerObjetivo02 = false;
    public int objetivo02Codigo;
    public static bool objetivo02Complete = false;
    /*
    //Logro 3
    public static bool triggerObjetivo03 = false;
    public int objetivo03Codigo;
    */
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

        if (objetivo01Complete)
        {
            //Reset
            objetivoPanel.SetActive(false);
            objetivoDescripcion.GetComponent<TextMeshProUGUI>().text = "";
            objetivoActivo = false;
            triggerObjetivo01 = false;
            objetivo01Complete = false;
        }

        if (objetivo02Complete)
        {
            //Reset
            objetivoPanel.SetActive(false);
            objetivoDescripcion.GetComponent<TextMeshProUGUI>().text = "";
            objetivoActivo = false;
            triggerObjetivo02 = false;
            objetivo02Complete = false;
        }
    }

    IEnumerator TriggerObjetivo01()
    {
        objetivoActivo = true;
        objetivo01Codigo = 12;
        //objetivoSonido.Play();
        objetivoDescripcion.GetComponent<TextMeshProUGUI>().text = "Mire alrededor y use su CABEZA";
        objetivoPanel.SetActive(true);
        objetivoPanel.transform.LeanMoveLocal(new Vector2(-390, 150), 1).setEaseOutBack();
        yield return new WaitForSeconds(0);
    }

    IEnumerator TriggerObjetivo02()
     {
        Debug.Log("entro obj 2");
        objetivoActivo = true;
        objetivo02Codigo = 13;
        //objetivoSonido.Play();
        objetivoDescripcion.GetComponent<TextMeshProUGUI>().text = "Ellos APUNTAN hacia mi objetivo";
        objetivoPanel.SetActive(true);
        objetivoPanel.transform.LeanMoveLocal(new Vector2(-390, 150), 1).setEaseOutBack();
        yield return new WaitForSeconds(0);
    }
}
