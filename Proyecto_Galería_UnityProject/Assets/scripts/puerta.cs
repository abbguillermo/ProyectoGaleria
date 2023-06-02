using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta : MonoBehaviour
{
    public bool abierta = false;
    public bool guille;
    public float velocida;
    public float angulito;
    public Vector3 direcion;
    private void Start()
    {
        angulito = transform.eulerAngles.y;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            abierta = true;   
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            abierta = false;
        }
    }


    private void Update()
    {

        if (Mathf.Round(transform.eulerAngles.y) != angulito)
        {
            transform.Rotate(direcion * velocida);
        }
        if (Input.GetKey(KeyCode.E) && abierta==true && guille== false)
        {
            angulito = 80;
            direcion = Vector3.up;
            guille = true;
        } else if ((Input.GetKey(KeyCode.E) && abierta == true && guille == true))
        {
            angulito = 0;
            direcion = Vector3.down;
            guille = false;
        }
        
    }
}

