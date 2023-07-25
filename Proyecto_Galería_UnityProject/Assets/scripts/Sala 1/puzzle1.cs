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

    public movCam MovCam;
    public GameObject pj;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    void FixedUpdate()
    {


        if (cuad1==true && cuad2==true && cuad3==true && cuad4==true)
        {
            Debug.Log("BIEN");
            StartCoroutine(MovCam.Movimiento());
            StartCoroutine(Abrir());
            pj.GetComponent<Animator>().Play("cambiarfov");
            //sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxPuertaDeslizada);
            FindObjectOfType<Agarrar>().spriteNota.SetActive(false);

        }
      
        
    }

    IEnumerator Abrir()
    {
        yield return new WaitForSeconds(0.3f);
        pared.GetComponent<Animator>().Play("AbrirP");
    }
}
