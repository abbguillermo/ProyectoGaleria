using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movCam : MonoBehaviour
{
    public float duracion = 0.6f;
    public float magnitud = 0.15f;


    public IEnumerator Movimiento()
    {
        Vector3 posicionOriginal = transform.localPosition;

        float elapsed = 0f;

        while (elapsed<duracion)
        {
            float x = 0.2f * magnitud;
            float y = 0.1f * magnitud;

            transform.localPosition = new Vector3(posicionOriginal.x + x, posicionOriginal.y + y, posicionOriginal.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        magnitud = 0;
        transform.localPosition = posicionOriginal;

    }

}
