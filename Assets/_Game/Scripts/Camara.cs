using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform objetivo;

    void Update()
    {
        Vector3 nuevaPosicion = objetivo.position;
        nuevaPosicion.x = 0;
        nuevaPosicion.y = 0;
        transform.position = nuevaPosicion;
    }
}
