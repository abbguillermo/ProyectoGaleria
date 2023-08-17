using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDsala3 : MonoBehaviour
{
    public int num;
  
    
  
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
       
    }
}
