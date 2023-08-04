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

    public GameObject pj;
    public GameObject cam;

    void FixedUpdate()
    {
        if (cuad1==true && cuad2==true && cuad3==true && cuad4==true)
        {
            Debug.Log("BIEN");
            pj.GetComponent<Animator>().SetTrigger("cambiarfov");
            StartCoroutine(Abrir());
            pared.transform.GetChild(0).GetComponent<AudioSource>().Play();
            cam.GetComponent<Animator>().SetTrigger("shake");
            //sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.sfxPuertaDeslizada);
            FindObjectOfType<Agarrar>().spriteNota.SetActive(false);
        }
    }

    IEnumerator Abrir()
    {
        yield return new WaitForSeconds(0.3f);
        pared.GetComponent<Animator>().Play("AbrirP");
        yield return new WaitForSeconds(0.3f);
        pj.GetComponent<Animator>().ResetTrigger("cambiarfov");
        cam.GetComponent<Animator>().ResetTrigger("shake");
        cam.GetComponent<Animator>().SetTrigger("idle");
        pj.GetComponent<Animator>().SetTrigger("fovnormal");
        yield return new WaitForSeconds(0.5f);
        cuad1 = false;
    }
}
