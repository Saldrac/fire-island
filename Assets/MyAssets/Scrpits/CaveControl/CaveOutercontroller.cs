using UnityEngine;
using System.Collections;

public class CaveOutercontroller : MonoBehaviour {
	public GameObject mainTerrain;

	void OnTriggerEnter (){

		mainTerrain.SetActive(true);
	}

}
