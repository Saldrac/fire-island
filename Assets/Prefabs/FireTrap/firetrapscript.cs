using UnityEngine;
using System.Collections;

public class firetrapscript : MonoBehaviour {

	public GameObject explosion_particle;
	public GameData gamedata;
	public int initial_damage;
	public int damage_over_time;
	
	public void Start(){
		gamedata = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>();
	}
	
	public void OnTriggerEnter(Collider other){
		explosion_particle.SetActive(true);
		gamedata.ApplyDamage(initial_damage);
		Destroy(gameObject,5);
		gameObject.GetComponent<AudioSource>().Play();
		gameObject.GetComponent<AudioSource>().loop = true;
	}

	public void OnTriggerStay(Collider other){
		if(other.gameObject.tag == "Player")
			gamedata.ApplyDamage(damage_over_time);
	}
	

}
