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




    private Quaternion cuadrorot1= Quaternion.Euler(0f, 270f, 180f);
    private Quaternion cuadrorot2 = Quaternion.Euler(0f,270f, 180f);
    private Quaternion cuadrorot3 = Quaternion.Euler(0f, 270f, 180f);
    private Quaternion cuadrorot4 = Quaternion.Euler(0f, 270f, 180f);


    private void Update()
    {
        if (btn1==true&&btn2==true&&btn3==true&&btn4==true)
        {
            pared.transform.Translate(new Vector3(0, 0, 1) * 1.02f * Time.deltaTime);
        } 
       

       
       
    }

    public void Rotarcuad1()
    {
      
        object1.Rotate(new Vector3(0,0,22.5f));
        
    }
    public void Rotarcuad2()
    {

        object2.Rotate(new Vector3(0, 0, 22.5f));
        
    }
    public void Rotarcuad3()
    {
        object3.Rotate(new Vector3(0, 0, 22.5f));
    }
    public void Rotarcuad4()
    {
        object4.Rotate(new Vector3(0, 0, 22.5f));
    }
   
    public void boton1()
    {
        btn1= true;
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
