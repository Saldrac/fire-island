using UnityEngine;
using System.Collections;

public class ExtraPhysics : MonoBehaviour {
	public float forceToAdd;
	void FixedUpdate() {
		GetComponent<Rigidbody>().AddForce(Vector3.up * forceToAdd);
	}
}
