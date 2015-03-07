using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public enum GameStatus {Talking, Exploring}; 
	public Camera mainCamera;

	public GameStatus gameStatus = GameStatus.Exploring;
	public GameObject playerController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void TogglePlayerControl(bool newStat){
/*		playerController.GetComponent<CharacterMotor>().enabled = newStat;
		playerController.GetComponent<MouseLook>().enabled = newStat;
		playerController.GetComponent<FPSInputController>().enabled = newStat;
		mainCamera.GetComponent<MouseLook>().enabled = newStat;*/
	}
}
