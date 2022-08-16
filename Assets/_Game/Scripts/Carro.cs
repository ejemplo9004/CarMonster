using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : MonoBehaviour
{
    public float     velocidad;
    public float     velRotacion;
    public Joystick  joy;
    public bool      vivo = true;
    public Rigidbody rb;
    public Camara    camara;

    void Update()
    {
        if(vivo)
        {
            transform.Translate(0, 0, velocidad*Time.deltaTime);
            transform.Rotate(0, velRotacion*Time.deltaTime * joy.Horizontal, 0);
        }
    }

    void OnCollisionEnter(Collision otro)
    {
        if (vivo && otro.collider.CompareTag("Obstaculo"))
        {
            Chocar();
        }
    }

    public void Chocar()
    {
        vivo = false;
        rb.AddForce(Vector3.up * 500 + transform.forward * 300);
        StartCoroutine(camara.Rotar(10));
    }

}
