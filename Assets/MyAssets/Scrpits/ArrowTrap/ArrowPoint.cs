using UnityEngine;
using System.Collections;

public class ArrowPoint : MonoBehaviour {
	public int damage = 10;
	public GameData gameData;
	public GameObject parentObject;
	// Use this for initialization
	void Start () {
		gameData = GameObject.Find ("GameController").GetComponent<GameData>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col){
		if (col.gameObject.tag == "Player"){
			Debug.Log ("arrow hit");
			gameData.ApplyDamage (damage);
			Destroy (parentObject);
		}

	}
}
