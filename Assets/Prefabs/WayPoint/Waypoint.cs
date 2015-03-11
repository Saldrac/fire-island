using UnityEngine;
using System.Collections;

public class Waypoint : MonoBehaviour {
	public GameData gamedata;
	//Set on inspector. First waypoint is 1, second is 2....
	public int weight;

	public void Awake(){
		gamedata = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>();
	}

	//We only change the waypoint if it is further than actual
	public void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Player" && gamedata.waypoint.GetComponent<Waypoint>().weight<this.weight)
			gamedata.setWayPoint(gameObject);
	}
}
