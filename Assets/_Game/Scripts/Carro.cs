using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : MonoBehaviour
{
    public float velocidad;
    public float velRotacion;
    public Joystick joy;

    void Update()
    {
        transform.Translate(0, 0, velocidad*Time.deltaTime);
        transform.Rotate(0, velRotacion*Time.deltaTime * joy.Horizontal, 0);
    }

}
