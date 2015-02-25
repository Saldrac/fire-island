using UnityEngine;
using System.Collections;

public class KillerZone : MonoBehaviour {
	public GameData gameData;
	void Start (){
		gameData = GameObject.Find ("GameController").GetComponent<GameData>();
	}

	void OnTriggerEnter (){

		gameData.ApplyDamage (200);
	}
}
