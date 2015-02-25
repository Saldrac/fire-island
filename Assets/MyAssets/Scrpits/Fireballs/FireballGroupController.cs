using UnityEngine;
using System.Collections;

public class FireballGroupController : MonoBehaviour {
	public GameObject ball;
	public GameObject spawnPoint;

	//public Vector3 spawnPoint;

	public void SpawnBall(){
		Instantiate (ball,spawnPoint.transform.position, Quaternion.identity);
	}
}
