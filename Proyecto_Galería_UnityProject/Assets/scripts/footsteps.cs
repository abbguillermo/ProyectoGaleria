using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{

    [SerializeField] AudioClip[] sonidos;

    AudioSource audiopasos;

    void Start()
    {
        audiopasos = GetComponent<AudioSource>();


    }


    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            Sonidos();
        }
        
    }

    void Sonidos()
    {
        int rand = Random.Range(0, sonidos.Length);
        audiopasos.clip= sonidos[rand];
        audiopasos.Play();
    }
}
