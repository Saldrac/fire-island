using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	public Teleport destination;

	public void OnTriggerEnter(Collider other){
		Vector3 position = destination.gameObject.transform.position;
		position.z = position.z + 5;
		other.gameObject.transform.position = position;
	}
}
