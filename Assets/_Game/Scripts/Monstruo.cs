using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstruo : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision)
	{
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Carro"))
		{
			GetComponent<Rigidbody>().AddForce(
				Vector3.up * 4 +
				other.transform.forward * 5);
			GetComponent<Rigidbody>().AddTorque(
				Random.Range(-80f, 80f),
				Random.Range(-80f, 80f),
				Random.Range(-80f, 80f)
				);
			GameObject.Find("Dios").GetComponent<DIos>().puntos++;
		}
	}
}
