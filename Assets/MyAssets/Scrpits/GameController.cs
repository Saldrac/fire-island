using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public int debugNumber = 0;

	public void ApplyDamage (int damage){
		Debug.Log (damage + " dagae points suffered");
		Debug.Log ("debug number " +debugNumber);
	}
}
