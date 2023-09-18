using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDsala3 : MonoBehaviour
{
    public int num;

    private void Start()
    {
        FindObjectOfType<WPtrigger>().s3 = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<IDsala3>().num == gameObject.GetComponent<IDsala3>().num)
        {
            if (other.tag == "Sala3/objeto1")
            {
                FindObjectOfType<puzzlesala3>().Objeto1bool = true;
            }
            if (other.tag == "Sala3/objeto2")
            {
                FindObjectOfType<puzzlesala3>().Objeto2bool = true;
            }
            if (other.tag == "Sala3/objeto3")
            {
                FindObjectOfType<puzzlesala3>().Objeto3bool = true;
            }
            if (other.tag == "Sala3/objeto4")
            {
                FindObjectOfType<puzzlesala3>().Objeto4bool = true;
            }
            /*if (other.tag == "Sala3/objeto5")
            {
                FindObjectOfType<puzzlesala3>().Objeto5bool = true;
            }
            if (other.tag == "Sala3/objeto6")
            {
                FindObjectOfType<puzzlesala3>().Objeto6bool = true;
            }*/
        }
        else if (other.GetComponent<IDsala3>().num != gameObject.GetComponent<IDsala3>().num)
        {
            Debug.Log("MAL GUILLE PESADO");
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Sala3/objeto1")
        {

            FindObjectOfType<puzzlesala3>().Objeto1bool = false;
        }
        if (other.tag == "Sala3/objeto2")
        {
            FindObjectOfType<puzzlesala3>().Objeto2bool = false;
        }
        if (other.tag == "Sala3/objeto3")
        {
            FindObjectOfType<puzzlesala3>().Objeto3bool = false;
        }
        if (other.tag == "Sala3/objeto4")
        {
            FindObjectOfType<puzzlesala3>().Objeto4bool = false;
        }
        /*if (other.tag == "Sala3/objeto5")
        {
            FindObjectOfType<puzzlesala3>().Objeto5bool = false;
        }
        if (other.tag == "Sala3/objeto6")
        {
            FindObjectOfType<puzzlesala3>().Objeto6bool = false;
        }
        */
    }
}
