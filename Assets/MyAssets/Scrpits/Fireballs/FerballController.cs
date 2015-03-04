using UnityEngine;
using System.Collections;

public class FerballController : MonoBehaviour {
	public GameData gameController;


	public int damageCaused = 0;
	public float forceToAdd = 0;


	//timer destroy
	float lifeTime =50;
	public float lifeTimer=0;

	void Start(){
		//gameController = GameObject.Find ("GameManager").GetComponent<GameController>();
		gameController = GameObject.Find ("GameController").GetComponent<GameData>();
	}

	void Update(){
		lifeTimer += Time.deltaTime;
		if (lifeTimer >= lifeTime)
			Destroy (gameObject);
	}


	void FixedUpdate() {
		GetComponent<Rigidbody>().AddForce(Vector3.up * forceToAdd);
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Player")
			gameController.ApplyDamage( damageCaused);
	}




}
