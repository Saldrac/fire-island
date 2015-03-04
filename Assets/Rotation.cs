using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
	public float add_angle;
	void Update () {
		transform.Rotate(Vector3.up, add_angle);
	}
}
