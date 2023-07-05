using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject luces;
   /* public GameObject luces2;
    public GameObject luces3;*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            luces.SetActive(true);
        }

       /* if (other.tag == "Player" && gameObject.tag == "collider/CP2")
        {
            luces2.SetActive(true);
        }

        if (other.tag == "Player")
        {
            luces3.SetActive(true);
        }*/

    }
}
