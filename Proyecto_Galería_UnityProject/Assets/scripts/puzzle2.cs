using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle2 : MonoBehaviour
{
    public Transform object1;
    public Transform object2;
    public Transform object3;
    public Transform object4;

    private bool resuelto = false;

    private Quaternion cuadrorot1= Quaternion.Euler(0f, 270f, 180f);
    private Quaternion cuadrorot2 = Quaternion.Euler(0f,270f, 180f);
    private Quaternion cuadrorot3 = Quaternion.Euler(0f, 270f, 180f);
    private Quaternion cuadrorot4 = Quaternion.Euler(0f, 270f, 180f);


    private void Update()
    {
        
       

       
        if (!resuelto)
        {
            if (Solucion())
            {
                resuelto = true;
                Debug.Log("Puzzle resolvido");
            }
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
    private bool Solucion()
    {
        if (object1.rotation== cuadrorot1)
        {
            
            if (object2.rotation== cuadrorot2)
            {
              
                if (object3.rotation== cuadrorot3)
                {

                    if (object4.rotation == cuadrorot4)
                    {

                        return true;
                    }
                }
            }
        }
        
        return false;
    }

}
