using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform objetivo;

    public float nivelRotacion = 20;

    Vector3 rotacionInicial;

    void Start()
    {
        rotacionInicial = transform.localEulerAngles;
    }

    void Update()
    {
        Vector3 nuevaPosicion = objetivo.position;
        nuevaPosicion.x = 0;
        nuevaPosicion.y = 0;
        transform.position = nuevaPosicion;
        
    }

    public IEnumerator Rotar(int cuanto)
    {
        for(int i = 0; i < cuanto; i++)
        {
            Vector3 nuevaRotacion = new Vector3
                                (
                                    Random.Range(-nivelRotacion, nivelRotacion),
                                    Random.Range(-nivelRotacion, nivelRotacion),
                                    Random.Range(-nivelRotacion, nivelRotacion)
                                );
            transform.localEulerAngles = rotacionInicial + nuevaRotacion;
            yield return new WaitForSeconds(0.03f);
        }
    }
}
