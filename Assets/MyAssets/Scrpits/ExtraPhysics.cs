using UnityEngine;
using System.Collections;

public class ExtraPhysics : MonoBehaviour {
	public float forceToAdd;
	void FixedUpdate() {
		rigidbody.AddForce(Vector3.up * forceToAdd);
	}
}
