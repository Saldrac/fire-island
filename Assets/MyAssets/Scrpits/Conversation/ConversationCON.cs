﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Conversation controller (only one for the full app)
public class ConversationCON : MonoBehaviour {

	public static int maxResponses = 4; //hide in inspector
	//references to external
	//GameObject dialogHolder;
	public Canvas mainCanvas;
	public GameManager gameManager;
	public ConversationAGE activeConversation; // to hide later

	public Text [] responses = new Text [maxResponses];//pointers to each button //to hide in inspector??
	public GameObject [] buttonsGO = new GameObject[maxResponses];
	//locals
	//ArrayList responses = new ArrayList();
	public Text npcText;
	Image portrait;
	Text npcName;
	// Use this for initialization

	void Start () {
		//first locate all interface elements
		////locate main canvas
		mainCanvas = GameObject.Find("DialogInterface").GetComponent<Canvas>();

		gameManager = GameObject.Find ("DialogHolder").GetComponent<GameManager>();

		////locate response buttons and texts
		for (int i = 0; i <= 3; i++){
			responses[i] = GameObject.Find("TextResponse"+i.ToString ()).GetComponent<Text>();
			buttonsGO[i] = GameObject.Find("ButtonResponse"+i.ToString());

		}                                 
		npcText = GameObject.Find("NPCText").GetComponent<Text>();
		//portrait = GameObject.Find("NPCPortrait").GetComponent<Image>();
		npcName = GameObject.Find("NPCName").GetComponent<Text>();

	}
	
	
	public void SendResponseSelection(int i){

		activeConversation.ProcessResponseSelection(i);

	}

	public void EnableInterface(){
		mainCanvas.enabled = true;
		//dialogHolder.SetActive(true);
		gameManager.gameStatus =GameManager.GameStatus.Talking;

		gameManager.TogglePlayerControl(false);


	}

	public void DisableInterface(){
		mainCanvas.enabled = false;
		//dialogHolder.SetActive(false);
		gameManager.gameStatus = GameManager.GameStatus.Exploring;

		gameManager.TogglePlayerControl(true);
	}



}
