using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPtrigger : MonoBehaviour
{
    public Transform Enemigo;
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
      
            FindObjectOfType<Logicaenemigo_sala2>().puedeatacar = true;
        }

      
    }
    public void OnTriggerExit(Collider other)
    {
       
        if (other.tag == "Player")
        {
            Debug.Log("aca llega");
            FindObjectOfType<Logicaenemigo_sala2>().puedeatacar = false;
        }
       /* if (other.tag == "WP")
        {
            FindObjectOfType<Logicaenemigo_sala2>().cambiarWP = false;
        }*/
    }   

    
}
