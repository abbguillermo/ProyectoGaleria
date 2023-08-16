using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle2 : MonoBehaviour
{
    public Transform object1;
    public Transform object2;
    public Transform object3;
    public Transform object4;
    public bool btn1=false;
    public bool btn2 = false;
    public bool btn3 = false;
    public bool btn4 = false;
    public GameObject pared;
    public GameObject interruptor1;
    public GameObject interruptor2;
    public GameObject interruptor3;
    public GameObject interruptor4;
    public GameObject luz1;
    public GameObject luz2;
    public GameObject luz3;
    public GameObject luz4;

    private Quaternion cuadrorot1= Quaternion.Euler(0f, 270f, 180f);
    private Quaternion cuadrorot2 = Quaternion.Euler(0f,270f, 180f);
    private Quaternion cuadrorot3 = Quaternion.Euler(0f, 270f, 180f);
    private Quaternion cuadrorot4 = Quaternion.Euler(0f, 270f, 180f);

    public GameObject pj;
    public GameObject cam;

    private void FixedUpdate()
    {
        if (btn1==true&&btn2==true&&btn3==true&&btn4==true)
        {
            StartCoroutine(Abrir());
            pared.transform.GetChild(0).GetComponent<AudioSource>().Play();
            pj.GetComponent<Animator>().SetTrigger("cambiarfov");
            cam.GetComponent<Animator>().SetTrigger("shake");
        }  
    }

    public void Rotarcuad1()
    {
      
        object1.Rotate(new Vector3(0,0, 45f));
        
    }
    public void Rotarcuad2()
    {

        object2.Rotate(new Vector3(0, 0, 45f));
        
    }
    public void Rotarcuad3()
    {
        object3.Rotate(new Vector3(0, 0, 45f));
    }
    public void Rotarcuad4()
    {
        object4.Rotate(new Vector3(0, 0, 45f));
    }
   
    public void boton1()
    {
        if (btn1 == true)
        {
            interruptor1.GetComponent<Animator>().Play("TeclaAbajo");
            luz1.SetActive(false);
            btn1 = false;
        }
        else
        {
            btn1 = true;
            interruptor1.GetComponent<Animator>().Play("TeclaArriba");
            luz1.SetActive(true);
        }
    }
    public void boton2()
    {
        if (btn2 == true)
        {
            interruptor2.GetComponent<Animator>().Play("TeclaAbajo");
            luz2.SetActive(false);
            btn2 = false;
        }
        else
        {
            btn2 = true;
            interruptor2.GetComponent<Animator>().Play("TeclaArriba");
            luz2.SetActive(true);
        }
    }
    public void boton3()
    {
        if (btn3 == true)
        {
            interruptor3.GetComponent<Animator>().Play("TeclaAbajo");
            luz3.SetActive(false);
            btn3 = false;
        }
        else
        {
            btn3 = true;
            interruptor3.GetComponent<Animator>().Play("TeclaArriba");
            luz3.SetActive(true);
        }
    }
    public void boton4()
    {
        if (btn4 == true)
        {
            interruptor4.GetComponent<Animator>().Play("TeclaAbajo");
            luz4.SetActive(false);
            btn4 = false;
        }
        else
        {
            btn4 = true;
            interruptor4.GetComponent<Animator>().Play("TeclaArriba");
            luz4.SetActive(true);
        }
    }

    IEnumerator Abrir()
    {
        yield return new WaitForSeconds(0.5f);
        pared.GetComponent<Animator>().Play("AbrirP2");
        yield return new WaitForSeconds(0.3f);
        pj.GetComponent<Animator>().ResetTrigger("cambiarfov");
        cam.GetComponent<Animator>().ResetTrigger("shake");
        cam.GetComponent<Animator>().SetTrigger("idle");
        pj.GetComponent<Animator>().SetTrigger("fovnormal");
        yield return new WaitForSeconds(0.5f);
        btn1 = false;
    }
}
