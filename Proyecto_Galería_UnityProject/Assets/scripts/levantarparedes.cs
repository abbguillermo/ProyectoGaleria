using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levantarparedes : MonoBehaviour
{

   public bool arriba=false;
    public GameObject paredes;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (arriba)
        {
            if (paredes.transform.position.y>=0)
            {
                paredes.transform.Translate(new Vector3(0, 0, 0));
            }
           
        }
    }
}
