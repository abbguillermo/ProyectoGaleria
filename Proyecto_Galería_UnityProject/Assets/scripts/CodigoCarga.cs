using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CodigoCarga : MonoBehaviour
{
    public string EscenaAcargar;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Cargarescena", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Cargarescena()
    {
        SceneManager.LoadScene(EscenaAcargar);
    }
}
