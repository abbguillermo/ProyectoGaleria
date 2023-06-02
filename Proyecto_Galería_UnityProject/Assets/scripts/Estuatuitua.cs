using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estuatuitua : MonoBehaviour
{
    public GameObject[] piezas;
    public ControlScroll mano;
   
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (mano.pieza1 == true)
                {
                    activarpieza(0);

                }
                if (mano.pieza2 == true)
                {
                    activarpieza(1);
                }
            }
           

        }
        
    }
    public void activarpieza(int numer)
    {
       /* for (int i = 0; i < piezas.Length; i++)
        {
            piezas[i].SetActive(false);
        }*/

        piezas[numer].SetActive(true);
    }



}
    

