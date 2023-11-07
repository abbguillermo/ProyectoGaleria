using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activarlogros : MonoBehaviour
{
    public GameObject imglogro1;
    public GameObject logro1desactivado;

    public GameObject imglogro2;
    public GameObject logro2desactivado;

    public GameObject imglogro3;
    public GameObject logro3desactivado;

    public GameObject imglogro4;
    public GameObject logro4desactivado;

    public GameObject imglogro5;
    public GameObject logro5desactivado;

    public GameObject imglogro6;
    public GameObject logro6desactivado;

    void Start()
    {
    }

    void Update()
    {
        int logro1 = PlayerPrefs.GetInt("logro01");
        if (logro1==12)
        {
            logro1desactivado.SetActive(false);
            imglogro1.SetActive(true);
        }

        int logro2 = PlayerPrefs.GetInt("logro02");
        if (logro2 == 13)
        {
            logro2desactivado.SetActive(false);
            imglogro2.SetActive(true);
        }

        int logro3 = PlayerPrefs.GetInt("logro03");
        if (logro3 == 14)
        {
            logro3desactivado.SetActive(false);
            imglogro3.SetActive(true);
        }

        int logro4 = PlayerPrefs.GetInt("logro04");
        if (logro4 == 15)
        {
            logro4desactivado.SetActive(false);
            imglogro4.SetActive(true);
        }

        int logro5 = PlayerPrefs.GetInt("logro05");
        if (logro5 == 16)
        {
            logro5desactivado.SetActive(false);
            imglogro5.SetActive(true);
        }

        int logro6 = PlayerPrefs.GetInt("logro06");
        if (logro6 == 17)
        {
            logro6desactivado.SetActive(false);
            imglogro6.SetActive(true);
        }
    }
}
