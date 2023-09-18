using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPtrigger : MonoBehaviour
{
    public Transform Enemigo;
    public bool s3=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        gameObject.transform.position=new Vector3(Enemigo.position.x,Enemigo.position.y,Enemigo.position.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
          
            
           
            if (s3)
            {
                Debug.Log("sdadsdadsa");
                FindObjectOfType<LogicaEnemigo_sala3>().puedeatacars3 = true;
            }
            else
            {
                FindObjectOfType<Logicaenemigo_sala2>().puedeatacar = true;
            }
         
        }

      
    }
    public void OnTriggerExit(Collider other)
    {
       
        if (other.tag == "Player")
        {
            
           
            
            if (s3)
            {
                FindObjectOfType<LogicaEnemigo_sala3>().puedeatacars3 = false;
            }
            else
            {
                FindObjectOfType<Logicaenemigo_sala2>().puedeatacar = false;
            }
            
        }
       /* if (other.tag == "WP")
        {
            FindObjectOfType<Logicaenemigo_sala2>().cambiarWP = false;
        }*/
    }   

    
}
