using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    //empty luces
    public GameObject lucescomp1;
    public GameObject lucescomp2;
    public GameObject lucescomp3;

    //luces P1
    public GameObject luces;
    public GameObject luces2;
    public GameObject luces3;
    public GameObject luces4;

    //luces P2
    public GameObject luces5;
    public GameObject luces6;
    public GameObject luces7;
    public GameObject luces8;

    //luces P3
    public GameObject luces9;
    public GameObject luces10;
    public GameObject luces11;
    public GameObject luces12;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "collider/CP1")
        {
            StartCoroutine(LucesPuzzle1());
        }

        if (other.tag == "collider/CP2")
        {
            StartCoroutine(LucesPuzzle2());
        }

        if (other.tag == "collider/CP3")
        {
            StartCoroutine(LucesPuzzle3());
        }

        if (other.tag == "collider/CP1OFF")
        {
            lucescomp1.SetActive(false);
        }
        else if (other.tag == "collider/CP2OFF")
        {
            lucescomp2.SetActive(false);
        }
        else if (other.tag == "collider/CP3OFF")
        {
            lucescomp3.SetActive(false);
        }

    }

    IEnumerator LucesPuzzle1()
    {
        luces.SetActive(true);
        yield return new WaitForSeconds(1f);
        luces2.SetActive(true);
        yield return new WaitForSeconds(1f);
        luces3.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        luces4.SetActive(true);
    }

    IEnumerator LucesPuzzle2()
    {
        luces5.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        luces6.SetActive(true);
        yield return new WaitForSeconds(1f);
        luces7.SetActive(true);
        yield return new WaitForSeconds(1f);
        luces8.SetActive(true);
    }

    IEnumerator LucesPuzzle3()
    {
        luces9.SetActive(true);
        yield return new WaitForSeconds(1f);
        luces10.SetActive(true);
        yield return new WaitForSeconds(1f);
        luces11.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        luces12.SetActive(true);
    }
}
