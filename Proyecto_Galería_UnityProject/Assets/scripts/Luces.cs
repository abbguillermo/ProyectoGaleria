using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luces : MonoBehaviour
{
    public bool ONOFF=false;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (ONOFF==true)
        {
            transform.GetChild(0).gameObject.SetActive(false);
           
            
        }
        if(ONOFF==false)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            
        }
    }
}
