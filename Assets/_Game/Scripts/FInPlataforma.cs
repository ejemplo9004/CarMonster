using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FInPlataforma : MonoBehaviour
{
    void OnTriggerEnter(Collider otro)
    {
        if (otro.CompareTag("Carro"))
        {
            GameObject.Find("Dios").GetComponent<DIos>().CrearPlataforma();
        }
    }
}
