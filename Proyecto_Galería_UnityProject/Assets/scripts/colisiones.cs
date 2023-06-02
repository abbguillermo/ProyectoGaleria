using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisiones : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "eventoprueba")
        {
            GameObject.FindGameObjectWithTag("fantasmas").transform.GetChild(0).gameObject.SetActive(true);
            Destroy(other);
        }

    }
}
