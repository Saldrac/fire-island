using UnityEngine;
using System.Collections;

public class DayNightCycle : MonoBehaviour {
	
	public float rotation_speed;
	public GameData gamedata;
	private Vector3 angles;

	public void Start(){
		gamedata = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>();

		angles = transform.eulerAngles;

/*	//comentado por Jose para el tema de rotaciones
 		angles.x = 0;
		angles.y = 0;
		angles.z = 0;
*/
	}


	// Update is called once per fixed frame
	void FixedUpdate () {
/*		//comentado por Jose para el tema de rotaciones
		  angles.x = (angles.x + rotation_speed)%360;
			transform.localEulerAngles = angles;
*/
		angles.x = (angles.x + rotation_speed) %360;
		transform.eulerAngles = angles;

		CheckChangeCicle();
	}

	void CheckChangeCicle(){
/* // comentado por Jose para el tema de las rotaciones
		if(transform.localEulerAngles.y == 0)
			gamedata.setDay(true);
		else
			gamedata.setDay(false);
*/
		if(angles.x >= 0 && angles.x<= 180)
			gamedata.setDay(true);
		else
			gamedata.setDay(false);
		
		
		}
}
