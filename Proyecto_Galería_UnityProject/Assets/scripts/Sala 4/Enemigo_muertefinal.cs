using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigo_muertefinal : MonoBehaviour
{
    //muerte
    private int entro = 0;
    public GameObject camara_jugador;
    public GameObject camara_muerte;
    public GameObject enemigoCamMuerte;
    public GameObject personaje;
    public AudioSource audiomuerte;
    public AudioClip grito;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Derrota();
        }
    }

    public void Derrota()
    {
        camara_jugador.SetActive(false);
        camara_muerte.SetActive(true);
        camara_muerte.GetComponent<Animator>().SetTrigger("shake");
        enemigoCamMuerte.GetComponent<Animator>().Play("Muerte4");
        personaje.SetActive(false);

        if (entro == 0)
        {

            audiomuerte.PlayOneShot(grito);

            entro += 1;

        }

        StartCoroutine(pasajeescena());
    }

    IEnumerator pasajeescena()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Final");
    }
}
