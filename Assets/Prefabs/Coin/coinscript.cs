using UnityEngine;
using System.Collections;

public class coinscript : MonoBehaviour {
	public GameData gamedata;
	public int value;
	public float verticalOffset;
	AudioSource audioSource;

	//for destroy process
	bool destroyRequest = false;
	float destroyTimer = 1;

	public void Start(){
		gamedata = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>();
		audioSource = GetComponent<AudioSource>();
		SetVerticalOffset ();
	}


	public void OnTriggerEnter(Collider collision){
		if(collision.gameObject.tag == "Player"){
			gamedata.incrementCoins(value);

			audioSource.Play();
			InitDestroyProcess();


		}

	}
	public void SetVerticalOffset(){
		RaycastHit hit;
		if (Physics.Raycast (transform.position, -Vector3.up,out  hit, Mathf.Infinity)){
			
			Vector3 newPosition = new Vector3 (transform.position.x, hit.point.y + verticalOffset, transform.position.z);
			transform.position = newPosition;
		}
	}

	void InitDestroyProcess(){
		GetComponent <SphereCollider> ().enabled = false;
		GetComponent <MeshRenderer>().enabled = false;
		Destroy (gameObject, 1);
	}

}
