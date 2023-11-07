using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class compFinal : MonoBehaviour
{
    public bool empieza = false;

    public GameObject camara;
    public GameObject puerta;

    public Volume m_Volume;
    public ColorAdjustments ca;
    public float exposición_Oscuro = 7f;

    // Start is called before the first frame update
    void Start()
    {
        empieza = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (empieza)
        {
            camara.GetComponent<Animator>().Play("Movimiento");
            Invoke("CerrarPuerta", 22);
            empieza = false;
        }
    }

    public void CerrarPuerta()
    {
        puerta.GetComponent<Animator>().Play("CerrarPuerta");
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxPuerta);
        Invoke("Oscuro", 0.95f);
    }

    public void Oscuro()
    {
        m_Volume.profile.TryGet(out ca);
        if (ca.postExposure.value > -5f)
        {
            ca.postExposure.value -= exposición_Oscuro;
        }
    }
}
