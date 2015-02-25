using UnityEngine;
using System.Collections;

public class Waypoint : MonoBehaviour {
	public GameData gamedata;


	public void Awake(){
		gamedata = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>();
	}


	public void OnTriggerEnter(Collider other){
		gamedata.setWayPoint(gameObject.transform);
	}
}
