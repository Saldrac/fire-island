using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	public Teleport destination;

	public void OnTriggerEnter(Collider other){
		Vector3 position = destination.gameObject.transform.position;
		position.x = position.x + 3;
		other.gameObject.transform.position = position;
	}
}
