using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logica_Gral : MonoBehaviour
{
    public Transform object1;
    private Quaternion evaluar = Quaternion.Euler(-90f,0 , -180f);
    int cont=0;

    public GameObject puertaSI;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (cont == 3)
        {
            gameObject.layer = 0;
            puertaSI.GetComponent<Animator>().Play("AbrirPuerta");
            puertaSI.GetComponent<AudioSource>().Play();
        }
    }

    public void Rotarcuad1()
    {
        object1.Rotate(new Vector3(0, 45, 0));
        cont += 1;
    }

}
