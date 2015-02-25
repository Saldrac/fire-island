using UnityEngine;
using System.Collections;

public class SpawnControl : MonoBehaviour {

	public FireballGroupController groupController;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter(Collider collision){
		if (collision.gameObject.tag == "Player")
			groupController.SpawnBall ();

	}
}
