using UnityEngine;
//DONT FORGET THIS IMPORT!!!
using UnityEngine.UI;
using System.Collections;

public class mainGUI : MonoBehaviour {
	public Text coins;
	public Text health;
	public GameData gamedata;

	public void Start(){
		gamedata = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>();
	}

	public void FixedUpdate(){
		coins.text = "Coins: " + gamedata.coins.ToString();
		health.text = "Health: " + gamedata.current_player_hp.ToString(); 
	}
}
