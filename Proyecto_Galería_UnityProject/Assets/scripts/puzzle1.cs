using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle1 : MonoBehaviour
{
    public GameObject pared;
    public bool cuad1=false;
    public bool cuad2=false;
    public bool cuad3=false;
    public bool cuad4=false;
   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {


        if (cuad1==true && cuad2==true && cuad3==true && cuad4==true)
        {
            Debug.Log("BIEN");
            if (pared.transform.position.z<=6)
            {
                pared.transform.Translate(new Vector3(0, 0, 1) * 0.01f);
            }
            
        }
      
        
    }
   
}
