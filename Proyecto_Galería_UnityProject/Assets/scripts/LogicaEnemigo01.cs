using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEnemigo01 : MonoBehaviour
{
    public Transform PJ;
    public float velocidadPersecusion;
    public bool papel=false;
    public bool puedemov = false;
    public Vector3 pos1;
    public Vector3 pos2;
    public Vector3 pos3;
    public Vector3 pos4;
    public Vector3 pos5;
    public Vector3 pos6;
    // Start is called before the first frame update
    void Start()
    {
        pos1 = new Vector3(-1.9f, 1.1f, 2.98f);
        pos2 = new Vector3(2.79f, 1.1f, 4);
        pos3 = new Vector3(0, 0, 0);
        pos4 = new Vector3(0, 0, 0);
        pos5 = new Vector3(0, 0, 0);
        pos6 = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (papel==true&& puedemov==true)
        {
            StartCoroutine(posiciones());

            puedemov = false;
        }
        
        
        
    }

    IEnumerator posiciones()
    {
        gameObject.transform.position = pos1;
        yield return new WaitForSeconds(5);
        gameObject.transform.position = pos2;
        yield return new WaitForSeconds(5);
        gameObject.transform.position = pos3;
        yield return new WaitForSeconds(5);
        gameObject.transform.position = pos4;
        yield return new WaitForSeconds(5);
        gameObject.transform.position = pos5;
        yield return new WaitForSeconds(5);
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
