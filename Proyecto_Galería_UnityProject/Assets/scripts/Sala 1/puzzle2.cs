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
    public GameObject marco1;
    public GameObject marco2;
    public GameObject marco3;
    public GameObject marco4;
    public int cont1;
    public int cont2;
    public int cont3;
    public int cont4;

    private Quaternion cuadrorot1= Quaternion.Euler(0f, 270f, 180f);
    private Quaternion cuadrorot2 = Quaternion.Euler(0f,270f, 180f);
    private Quaternion cuadrorot3 = Quaternion.Euler(0f, 270f, 180f);
    private Quaternion cuadrorot4 = Quaternion.Euler(0f, 270f, 180f);

    public GameObject pj;
    public GameObject cam;


    private void FixedUpdate()
    {
        Debug.Log(cont1);
        if (cont3 >= 3)
        {
            marco1.layer = 0;
        }
        if (cont4 >= 5)
        {
            marco2.layer = 0;
        }
        if (cont1 >= 5)
        {
            marco3.layer = 0;
        }
        if (cont2 >= 7)
        {
            marco4.layer = 0;
        }
        if (btn1==true&&btn2==true&&btn3==true&&btn4==true)
        {
            interruptor1.layer = 0;
            interruptor2.layer = 0;
            interruptor3.layer = 0;
            interruptor4.layer = 0;
            StartCoroutine(Abrir());
            pared.transform.GetChild(0).GetComponent<AudioSource>().Play();
            pj.GetComponent<Animator>().SetTrigger("cambiarfov");
            cam.GetComponent<Animator>().SetTrigger("shake");
            objetivosManager.objetivo02Complete = true;
        }
    }

    public void Rotarcuad1()
    {
        object1.Rotate(new Vector3(0,0, 45f));

        cont1 += 1;
    }
    public void Rotarcuad2()
    {

        object2.Rotate(new Vector3(0, 0, 45f));
        cont2 += 1;
    }
    public void Rotarcuad3()
    {
        object3.Rotate(new Vector3(0, 0, 45f));
        cont3 += 1;
    }
    public void Rotarcuad4()
    {
        object4.Rotate(new Vector3(0, 0, 45f));
        cont4 += 1;
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
