using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activarlogros : MonoBehaviour
{
    public GameObject imglogro1;
    public GameObject imglogro2;
    public GameObject imglogro3;
    public GameObject imglogro4;
    public GameObject imglogro5;
    public GameObject imglogro6;
    public GameObject imglogro7;
    // Start is called before the first frame update
    void Start()
    {
        imglogro1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int logro1 = PlayerPrefs.GetInt("activarlogro01");
        Debug.Log(logro1);
        if (logro1==1)
        {
            imglogro1.SetActive(true);
        }
        int logro2 = PlayerPrefs.GetInt("activarlogro02");
        
        if (logro2 == 1)
        {
            imglogro2.SetActive(true);
        }
        int logro3 = PlayerPrefs.GetInt("activarlogro03");
        Debug.Log(logro1);
        if (logro3 == 1)
        {
            imglogro3.SetActive(true);
        }
        int logro4 = PlayerPrefs.GetInt("activarlogro04");

        if (logro4 == 1)
        {
            imglogro4.SetActive(true);
        }
        if (logro2 == 1)
        {
            imglogro2.SetActive(true);
        }
        int logro5 = PlayerPrefs.GetInt("activarlogro05");
        Debug.Log(logro1);
        if (logro5 == 1)
        {
            imglogro5.SetActive(true);
        }
        int logro6 = PlayerPrefs.GetInt("activarlogro06");

        if (logro6 == 1)
        {
            imglogro6.SetActive(true);
        }
        int logro7 = PlayerPrefs.GetInt("activarlogro07");

        if (logro7 == 1)
        {
            imglogro7.SetActive(true);
        }
    }
}
