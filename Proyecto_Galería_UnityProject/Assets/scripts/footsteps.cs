using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class footsteps : MonoBehaviour
{
    public AudioClip[] steps;
    public List<AudioClip> randomlist;
    AudioSource source;

    public float walkingSpeed = -1000;
    [SerializeField]
    AudioMixerGroup mixerOutput;
    /*
    [SerializeField]
    float pitchMin = 0.95f;

    [SerializeField]
    float pitchMax = 1.85f;

    [SerializeField]
    float volumeMin = 0.95f;

    [SerializeField]
    float volumeMax = 1.00f;*/

    bool playerisMoving;

    void Start()
    {
        randomlist = new List<AudioClip>(new AudioClip[steps.Length]);
        InvokeRepeating("CallFoosteps", 0, walkingSpeed);
        source = gameObject.AddComponent<AudioSource>();
        source.outputAudioMixerGroup = mixerOutput;

        for (int i = 0; i < steps.Length; i++)
        {
            randomlist[i] = steps[i];
        }
    }

    void Update()
    {
        if (Input.GetAxis("Vertical") >= 0.02f || Input.GetAxis("Horizontal") >= 0.02f || Input.GetAxis("Vertical") < 0f || Input.GetAxis("Horizontal") < 0f)
        {
            playerisMoving = true;
        }
        else if (Input.GetAxis("Vertical") == 0f || Input.GetAxis("Horizontal") == 0f) 
        {
            playerisMoving = false;
        }
    }

    public void Reset()
    {
        for (int i = 0; i < steps.Length; i++)
        {
            randomlist.Add(steps[i]);
        }
    }

    public void CallFoosteps()
    {
        if (playerisMoving == true)
        {
            PlayRandomSound();
        }
    }

    public void PlayRandomSound()
    {
        int i = Random.Range(0, randomlist.Count);
        /*source.pitch = Random.Range(pitchMin, pitchMax);
        source.volume = Random.Range(volumeMin, volumeMax);*/
        source.PlayOneShot(randomlist[i]);
        randomlist.RemoveAt(i);

        if (randomlist.Count == 0)
        {
            Reset();
        }

    }
}



    /*[SerializeField] AudioClip[] sonidos;

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
    }*/

