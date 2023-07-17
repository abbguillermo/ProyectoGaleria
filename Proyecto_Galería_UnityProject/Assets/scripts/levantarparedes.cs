using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levantarparedes : MonoBehaviour
{

    public bool subir = false;
    public GameObject Laberinto;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (subir == true)
        {
            Laberinto.GetComponent<Animator>().Play("SubirLaberinto");
        }
    }
}
