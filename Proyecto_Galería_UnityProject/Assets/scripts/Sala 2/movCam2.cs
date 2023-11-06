using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movCam2 : MonoBehaviour
{
    public float speed = 5.0f;
    public float sensitivity = 5.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
         float mouseX = Input.GetAxis("Mouse X");
         float mouseY = Input.GetAxis("Mouse Y");
         transform.eulerAngles += new Vector3(-mouseY* sensitivity, mouseX* sensitivity, 0);

        if (Input.GetKeyDown(KeyCode.E))
        {
            FindObjectOfType<levantarparedes>().pj.SetActive(true);
            this.gameObject.SetActive(false);

            if (FindObjectOfType<Logica_Gral>().sala1 == true)
            {
                FindObjectOfType<levantarparedes>().pj.SetActive(true);
                this.gameObject.SetActive(false);
                logrosManager.triggerLogro05 = true;
                FindObjectOfType<Logica_Gral>().sala1 = false;
            }   
        }
    }
}

