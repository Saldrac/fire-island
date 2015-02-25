using UnityEngine;
using System.Collections;

public class EraserController : MonoBehaviour {
	public void OnTriggerEnter (Collider col){
		if (col.gameObject.tag == "Fireball"){
			Destroy (col.gameObject);
		}
	}
}
