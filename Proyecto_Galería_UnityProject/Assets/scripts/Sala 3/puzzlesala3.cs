using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzlesala3 : MonoBehaviour
{
    public GameObject objeto1;
    public GameObject objeto2;
    public GameObject objeto3;
    public GameObject objeto4;
    public GameObject objeto5;
    public GameObject objeto6;
    public bool Objeto1bool;
    public bool Objeto2bool;
    public bool Objeto3bool;
    public bool Objeto4bool;
    public bool Objeto5bool;
    public bool Objeto6bool;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Objeto1bool && Objeto2bool && Objeto3bool && Objeto4bool && Objeto5bool && Objeto6bool)
        {
            Debug.Log("bien");
        }
    }
}
