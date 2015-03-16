using UnityEngine;
using System.Collections;

public class KillerZone : MonoBehaviour {
	public GameData gameData;
	void Start (){
		gameData = GameObject.Find ("GameController").GetComponent<GameData>();
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Player")
			gameData.ApplyDamage (200);
	}
}
