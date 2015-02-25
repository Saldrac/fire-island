using UnityEngine;
using System.Collections;

public class ArrowTrigger : MonoBehaviour {
	public GameObject arrows;
	public GameObject spawnPoint;
	public GameObject arrowPack;


	void OnTriggerEnter (Collider col){
		if (col.gameObject.tag == "Player")
			Instantiate (arrowPack, spawnPoint.transform.position, spawnPoint.transform.rotation);
			/*}
		Transform[] ts = arrows.GetComponentsInChildren<Transform>();

		foreach (Transform child in ts) {
			if (child.tag == "Arrow")
				child.GetComponent<Arrow>().Shoot();
		}
*/

	}
}
