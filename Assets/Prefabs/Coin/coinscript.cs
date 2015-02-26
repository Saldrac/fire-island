using UnityEngine;
using System.Collections;

public class coinscript : MonoBehaviour {
	public GameData gamedata;
	public int value;

	public void Start(){
		gamedata = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>();
	}

	public void OnTriggerEnter(Collider collision){
		if(collision.gameObject.tag == "Player"){
			gamedata.incrementCoins(value);
			Destroy(gameObject);
		}
	}
}
