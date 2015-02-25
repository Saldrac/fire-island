using UnityEngine;
using System.Collections;

public class CaveInnerController : MonoBehaviour {


	public GameObject mainTerrain;
	void OnTriggerEnter(){
		mainTerrain.SetActive (false);
	}
}
