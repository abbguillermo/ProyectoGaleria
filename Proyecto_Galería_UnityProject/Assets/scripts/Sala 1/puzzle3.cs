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

    public GameObject pj;
    public GameObject cam;


    private void FixedUpdate()
    {
        if (cuad1==true&&cuad2==true&&cuad3==true&&cuad4==true)
        {
            StartCoroutine(Abrir());
            pared.transform.GetChild(0).GetComponent<AudioSource>().Play();
            //pj.GetComponent<Animator>().Play("cambiarfov");
            cam.GetComponent<Animator>().SetTrigger("shake");
        }

    }

    public void Rotarcuad1()
    {

        if (cuad1 == true)
        {
            cuad1 = false;
            object1.GetComponent<Animator>().Play("Giro");
            interruptor1.GetComponent<Animator>().Play("TeclaAbajo");
        }
        else
        {
            cuad1 = true;
            object1.GetComponent<Animator>().Play("Giro2");
            interruptor1.GetComponent<Animator>().Play("TeclaArriba");
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
            interruptor1.GetComponent<Animator>().Play("TeclaAbajo");
        }
        else
        {
            cuad1 = true;
            object1.GetComponent<Animator>().Play("Giro2");
            interruptor1.GetComponent<Animator>().Play("TeclaArriba");
        }

        if (cuad2 == true)
        {
            cuad2 = false;
            object2.GetComponent<Animator>().Play("Giro2");
            interruptor2.GetComponent<Animator>().Play("TeclaArriba");
        }
        else
        {
            cuad2 = true;
            object2.GetComponent<Animator>().Play("Giro");
            interruptor2.GetComponent<Animator>().Play("TeclaAbajo");
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
            interruptor1.GetComponent<Animator>().Play("TeclaAbajo");
        }
        else
        {
            cuad1 = true;
            object1.GetComponent<Animator>().Play("Giro2");
            interruptor1.GetComponent<Animator>().Play("TeclaArriba");
        }

        if (cuad2 == true)
        {
            cuad2 = false;
            object2.GetComponent<Animator>().Play("Giro2");
            interruptor2.GetComponent<Animator>().Play("TeclaArriba");
        }
        else
        {
            cuad2 = true;
            object2.GetComponent<Animator>().Play("Giro");
            interruptor2.GetComponent<Animator>().Play("TeclaAbajo");
        }

        if (cuad3 == true)
        {
            cuad3 = false;
            object3.GetComponent<Animator>().Play("Giro");
            interruptor3.GetComponent<Animator>().Play("TeclaAbajo");
        }
        else
        {
            cuad3 = true;
            object3.GetComponent<Animator>().Play("Giro2");
            interruptor3.GetComponent<Animator>().Play("TeclaArriba");
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
            interruptor1.GetComponent<Animator>().Play("TeclaAbajo");
        }
        else
        {
            cuad1 = true;
            object1.GetComponent<Animator>().Play("Giro2");
            interruptor1.GetComponent<Animator>().Play("TeclaArriba");
        }

        if (cuad2 == true)
        {
            cuad2 = false;
            object2.GetComponent<Animator>().Play("Giro2");
            interruptor2.GetComponent<Animator>().Play("TeclaArriba");
        }
        else
        {
            cuad2 = true;
            object2.GetComponent<Animator>().Play("Giro");
            interruptor2.GetComponent<Animator>().Play("TeclaAbajo");
        }

        if (cuad3 == true)
        {
            cuad3 = false;
            object3.GetComponent<Animator>().Play("Giro");
            interruptor3.GetComponent<Animator>().Play("TeclaAbajo");
        }
        else
        {
            cuad3 = true;
            object3.GetComponent<Animator>().Play("Giro2");
            interruptor3.GetComponent<Animator>().Play("TeclaArriba");
        }

        if (cuad4 == true)
        {
            cuad4 = false;
            object4.GetComponent<Animator>().Play("Giro2");
            interruptor4.GetComponent<Animator>().Play("TeclaArriba");
        }
        else
        {
            cuad4 = true;
            object4.GetComponent<Animator>().Play("Giro");
            interruptor4.GetComponent<Animator>().Play("TeclaAbajo");
        }

    }

    public void boton1()
    {
        btn1 = true;
    }
    public void boton2()
    {
        btn2 = true;
    }
    public void boton3()
    {
        btn3 = true;
    }
    public void boton4()
    {
        btn4 = true;
    }
    
    IEnumerator Abrir()
    {
        yield return new WaitForSeconds(1.5f);
        pared.GetComponent<Animator>().Play("AbrirP3");
        yield return new WaitForSeconds(0.3f);
        cam.GetComponent<Animator>().ResetTrigger("shake");
        cam.GetComponent<Animator>().SetTrigger("idle");
        yield return new WaitForSeconds(0.5f);
        cuad1 = false;
        btn4 = true;
    }
}
