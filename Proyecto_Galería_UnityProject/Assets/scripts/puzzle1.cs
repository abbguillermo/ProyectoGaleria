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

    void FixedUpdate()
    {


        if (cuad1==true && cuad2==true && cuad3==true && cuad4==true)
        {
            Debug.Log("BIEN");
            pared.GetComponent<Animator>().Play("AbrirP");
            //sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxPuertaDeslizada);
            FindObjectOfType<Agarrar>().spriteNota.SetActive(false);

        }
      
        
    }

}
