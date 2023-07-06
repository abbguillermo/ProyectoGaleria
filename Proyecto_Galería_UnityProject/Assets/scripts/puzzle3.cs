using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle3 : MonoBehaviour
{
    public Transform object1;
    public Transform object2;
    public Transform object3;
    public Transform object4;
    public bool btn1 = false;
    public bool btn2 = false;
    public bool btn3 = false;
    public bool btn4 = false;
    public GameObject pared;
    public GameObject interruptor1;
    public GameObject interruptor2;
    public GameObject interruptor3;
    public GameObject interruptor4;

    public bool cuad1=true;
    public bool cuad2=false;
    public bool cuad3=true;
    public bool cuad4=false;


    private void Update()
    {
        if (cuad1==true&&cuad2==true&&cuad3==true&&cuad4==true)
        {
            Debug.Log("asdawasdwasd");
            pared.transform.Translate(new Vector3(0, 0, 1) * 1.02f * Time.deltaTime);
        }

    }

    public void Rotarcuad1()
    {

        if (cuad1 == true)
        {
            cuad1 = false;
            object1.GetComponent<Animator>().Play("Giro");
        }
        else
        {
            cuad1 = true;
            object1.GetComponent<Animator>().Play("Giro2");
        }
       

    }
    public void Rotarcuad2()
    {

        object2.Rotate(new Vector3(0, 180, 0));
        object1.Rotate(new Vector3(0, 180, 0));

        if (cuad1 == true)
        {
            cuad1 = false;
            object1.GetComponent<Animator>().Play("Giro");
        }
        else
        {
            cuad1 = true;
            object1.GetComponent<Animator>().Play("Giro2");
        }

        if (cuad2 == true)
        {
            cuad2 = false;
            object2.GetComponent<Animator>().Play("Giro");
        }
        else
        {
            cuad2 = true;
            object2.GetComponent<Animator>().Play("Giro2");
        }
    }
    public void Rotarcuad3()
    {
        object2.Rotate(new Vector3(0, 180, 0));
        object1.Rotate(new Vector3(0, 180, 0));
        object3.Rotate(new Vector3(0, 180, 0));

        if (cuad1 == true)
        {
            cuad1 = false;
            object1.GetComponent<Animator>().Play("Giro");
        }
        else
        {
            cuad1 = true;
            object1.GetComponent<Animator>().Play("Giro2");
        }

        if (cuad2 == true)
        {
            cuad2 = false;
            object2.GetComponent<Animator>().Play("Giro");
        }
        else
        {
            cuad2 = true;
            object2.GetComponent<Animator>().Play("Giro2");
        }

        if (cuad3 == true)
        {
            cuad3 = false;
            object3.GetComponent<Animator>().Play("Giro");
        }
        else
        {
            cuad3 = true;
            object3.GetComponent<Animator>().Play("Giro2");
        }

    }
    public void Rotarcuad4()
    {
        object4.Rotate(new Vector3(0, 180, 0));
        object2.Rotate(new Vector3(0, 180, 0));
        object1.Rotate(new Vector3(0, 180, 0));
        object3.Rotate(new Vector3(0, 180, 0));

        if (cuad1 == true)
        {
            cuad1 = false;
            object1.GetComponent<Animator>().Play("Giro");
        }
        else
        {
            cuad1 = true;
            object1.GetComponent<Animator>().Play("Giro2");
        }

        if (cuad2 == true)
        {
            cuad2 = false;
            object2.GetComponent<Animator>().Play("Giro");
        }
        else
        {
            cuad2 = true;
            object2.GetComponent<Animator>().Play("Giro2");
        }

        if (cuad3 == true)
        {
            cuad3 = false;
            object3.GetComponent<Animator>().Play("Giro");
        }
        else
        {
            cuad3 = true;
            object3.GetComponent<Animator>().Play("Giro2");
        }

        if (cuad4 == true)
        {
            cuad4 = false;
            object4.GetComponent<Animator>().Play("Giro");
        }
        else
        {
            cuad4 = true;
            object4.GetComponent<Animator>().Play("Giro2");
        }

    }

    public void boton1()
    {
        btn1 = true;
        interruptor1.transform.Rotate(new Vector3(66, 0, 0));
    }
    public void boton2()
    {
        btn2 = true;
        interruptor2.transform.Rotate(new Vector3(66, 0, 0));
    }
    public void boton3()
    {
        btn3 = true;
        interruptor3.transform.Rotate(new Vector3(66, 0, 0));
    }
    public void boton4()
    {
        btn4 = true;
        interruptor4.transform.Rotate(new Vector3(66, 0, 0));
    }
    
}
