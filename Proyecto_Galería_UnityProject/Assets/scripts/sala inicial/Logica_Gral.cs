using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logica_Gral : MonoBehaviour
{
    public Transform object1;
    private Quaternion evaluar = Quaternion.Euler(-90f,0 , -180f);
    int cont=0;

    public GameObject puertaSI;
    public AudioSource audioSourcePuerta;
    public AudioClip audioPuerta;

    void Update()
    {
        if (cont == 3)
        {
            gameObject.layer = 0;
            puertaSI.GetComponent<Animator>().Play("AbrirPuerta");
            StartCoroutine(audioP());
        }
    }

    public void Rotarcuad1()
    {
        object1.Rotate(new Vector3(0, 45, 0));
        cont += 1;
    }

    IEnumerator audioP()
    {
        audioSourcePuerta.PlayOneShot(audioPuerta);
        cont = 0;
        yield return new WaitForSeconds(0f);
    }
}
