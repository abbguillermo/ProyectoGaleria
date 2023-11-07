using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDsala4 : MonoBehaviour
{
    public int num;
    public bool reja3=false;
    public bool rejita = false;
    public GameObject Reja3;

    public AudioSource audioSourceReja3;

    void Update()
    {
        if (reja3&&Reja3.transform.position.y<=2)
        {
            Reja3.transform.Translate(Vector3.up * 0.2f * Time.deltaTime);
        }

        if (rejita)
        {
            StartCoroutine(Audio());
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<IDsala4>().num == gameObject.GetComponent<IDsala4>().num)
        {
            if (other.tag == "Sala4/objeto1")
            {
                reja3 = true;
                rejita = true;
            }
        }

    }

    IEnumerator Audio()
    {
        rejita = false;
        audioSourceReja3.Play();
        yield return new WaitForSeconds(0f);
    }
}
