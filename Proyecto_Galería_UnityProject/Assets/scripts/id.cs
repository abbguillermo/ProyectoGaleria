using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class id : MonoBehaviour
{
    public int num;
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
        if (other.GetComponent<id>().num == gameObject.GetComponent<id>().num)
        {
            if (other.tag == "cuadro1")
            {
                FindObjectOfType<puzzle1>().cuad1 = true;
            }
            if (other.tag == "cuadro2")
            {
                FindObjectOfType<puzzle1>().cuad2 = true;
            }
            if (other.tag == "cuadro3")
            {
                FindObjectOfType<puzzle1>().cuad3 = true;
            }
            if (other.tag == "cuadro4")
            {
                FindObjectOfType<puzzle1>().cuad4 = true;
            }

        }
        else if (other.GetComponent<id>().num != gameObject.GetComponent<id>().num)
        {
            Debug.Log("MAL GUILLE PESADO");
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "cuadro1")
        {
            Debug.Log("sidhasda");
            FindObjectOfType<puzzle1>().cuad1 = false;
        }
        if (other.tag == "cuadro2")
        {
            FindObjectOfType<puzzle1>().cuad2 = false;
        }
        if (other.tag == "cuadro3")
        {
            FindObjectOfType<puzzle1>().cuad3 = false;
        }
        if (other.tag == "cuadro4")
        {
            FindObjectOfType<puzzle1>().cuad4 = false;
        }
    }
   
}
