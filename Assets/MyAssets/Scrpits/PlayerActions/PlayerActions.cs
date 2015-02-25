using UnityEngine;
using System.Collections;

public class PlayerActions : MonoBehaviour {
	public Camera raycastCamera;
	public GameData gameData;
	public flaregun flareGunReference;

	public void Start(){
		gameData = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>();
	}

		void Update() {
			
			


			if (Input.GetMouseButtonDown(0) && flareGunReference.spareRounds>0 ){
				RaycastHit hit;

			//Physics.Raycast (head.Gaze.origin, head.Gaze.direction, out hit, Mathf.Infinity);
			if (Physics.Raycast (raycastCamera.transform.position, raycastCamera.transform.forward, out hit, Mathf.Infinity)){
					
					if (hit.transform.tag == "ExitPoint")
						gameData.Victory();

			}


		}

		Debug.DrawRay(raycastCamera.transform.position, raycastCamera.transform.forward*500, Color.red);
		}
		
	}

