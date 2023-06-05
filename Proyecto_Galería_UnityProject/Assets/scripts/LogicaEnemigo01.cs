using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEnemigo01 : MonoBehaviour
{
    public Transform PJ;
    public float velocidad;
    public bool papel=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (papel==true)
        {
            if (gameObject.transform.position.x < PJ.position.x)
            {
                gameObject.transform.Translate(Vector3.forward * velocidad);
            }
            else if (gameObject.transform.position.x > PJ.position.x)
            {
                gameObject.transform.LookAt(PJ);
                gameObject.transform.Translate(Vector3.forward * 0.08f*Time.deltaTime);
            }
        }
        
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player" && papel==true)
        {
            Derrota();
        }
    }
    private void Derrota()
    {
        Debug.Log("MUERTO");
    }
}
