using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DIos : MonoBehaviour
{
    public GameObject[] plataforma;
    public int puntos;
    public int cuenta = -2;
    public Text txtPuntos;
    
    void Start()
    {
        CrearPlataforma();
        CrearPlataforma();
        CrearPlataforma();
        CrearPlataforma();
        CrearPlataforma();
    }

	private void Update()
	{
        txtPuntos.text = puntos.ToString();
	}

	public void CrearPlataforma()
    {
        Instantiate(plataforma[Random.Range(0,plataforma.Length)], Vector3.forward * 10 * cuenta, Quaternion.identity);
        cuenta++;
    }
}
