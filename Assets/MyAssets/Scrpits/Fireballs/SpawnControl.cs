using UnityEngine;
using System.Collections;

public class SpawnControl : MonoBehaviour {
	//vars to expose
	public float coolingTime = 15;
	
	//to hide
	public float coolingTimer = 0;
	public bool cooling = false;
	
	public FireballGroupController groupController;
	// Use this for initialization
	void Start () {
		coolingTimer = coolingTime;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (cooling){
			coolingTimer -= Time.deltaTime;
			if (coolingTimer <= 0){
				coolingTimer = coolingTime;
				cooling = false;
			}
		}
		
		
	}
	
	public void OnTriggerEnter(Collider collision){
		if ((collision.gameObject.tag == "Player") && (!cooling)){
			groupController.SpawnBall ();
			cooling = true;
			
		}
		
	}
}
