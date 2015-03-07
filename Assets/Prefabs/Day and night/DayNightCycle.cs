using UnityEngine;
using System.Collections;

public class DayNightCycle : MonoBehaviour {
	
	public float rotation_speed;
	public GameData gamedata;
	private Vector3 angles;

	public void Start(){
		gamedata = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>();
		angles.x = 0;
		angles.y = 0;
		angles.z = 0;
	}


	// Update is called once per fixed frame
	void FixedUpdate () {
		angles.x = (angles.x + rotation_speed)%360;
		transform.localEulerAngles = angles;
		Debug.Log(transform.localEulerAngles);
		CheckChangeCicle();
	}

	void CheckChangeCicle(){
		if(transform.localEulerAngles.y == 0)
			gamedata.setDay(true);
		else
			gamedata.setDay(false);


		}
}
