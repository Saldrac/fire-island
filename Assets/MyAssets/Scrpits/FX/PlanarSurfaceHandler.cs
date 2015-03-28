using UnityEngine;
using System.Collections;

public class PlanarSurfaceHandler : MonoBehaviour {
	public GameObject target;



	
	// Update is called once per frame
	void Update () {
		Vector3 currentRotation = transform.eulerAngles;
		transform.LookAt (target.transform);
		transform.eulerAngles =  new Vector3 (0f, transform.eulerAngles.y, 0f);


	}
}
