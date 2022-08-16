using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIos : MonoBehaviour
{
    public GameObject plataforma;

    public int cuenta = 0;
    
    void Start()
    {
        CrearPlataforma();
        CrearPlataforma();
        CrearPlataforma();
        CrearPlataforma();
    }


    public void CrearPlataforma()
    {
        Instantiate(plataforma, Vector3.forward * 10 * cuenta, Quaternion.identity);
        cuenta++;
    }
}
