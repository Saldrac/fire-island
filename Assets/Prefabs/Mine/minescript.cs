using UnityEngine;
using System.Collections;

public class minescript : MonoBehaviour {
	public GameObject explosion_particle;
	public GameData gamedata;
	public int damage;

	public void Start(){
		gamedata = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>();
	}

	public void OnTriggerEnter(Collider other){
		explosion_particle.SetActive(true);
		gamedata.ApplyDamage(damage);
		Invoke("SelfDestruction",3);
		gameObject.GetComponent<AudioSource>().Play();
		Destroy(gameObject.GetComponent<BoxCollider>());
	}

	public void SelfDestruction(){
		Destroy(gameObject);
	}
}
