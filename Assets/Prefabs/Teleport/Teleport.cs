using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	public Teleport destination;
	public Transform spanwpoint;

	public void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Player"){
			Vector3 position = destination.spanwpoint.transform.position;
			other.gameObject.transform.position = position;
		}
	}
}
