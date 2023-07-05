using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject luces;
    public GameObject luces2;
    public GameObject luces3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "collider/CP1")
        {
            luces.SetActive(true);
        }else if (other.tag == "collider/CP2")
        {
            luces2.SetActive(true);
        }else if(other.tag == "collider/CP3")
        {
            luces3.SetActive(true);
        }

        if (other.tag == "collider/CP1OFF")
        {
            luces.SetActive(false);
        }
        else if (other.tag == "collider/CP2OFF")
        {
            luces2.SetActive(false);
        }
        else if (other.tag == "collider/CP3OFF")
        {
            luces3.SetActive(false);
        }

    }
}
