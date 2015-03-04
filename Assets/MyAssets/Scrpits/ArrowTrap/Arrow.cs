using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {
	public float power;
	public bool moving = false;
	public bool toDelete = false;

	Vector3 angularOffset = new Vector3 (0f,0.7f,0f);


	public float timeLimit = 5;
	public float timer = 0;
	//public float scatterOffset;

	// Use this for initialization
	void Start () {
		Shoot ();

	}
	
	// Update is called once per frame
	void LateUpdate () {

			if (moving)
				transform.forward =	Vector3.Slerp(transform.forward, GetComponent<Rigidbody>().velocity.normalized - angularOffset , Time.deltaTime);

			if (toDelete)
				timer += Time.deltaTime;
			if (timer >= timeLimit)
				Destroy (gameObject);
	
	}



	void OnCollisionEnter (Collision col){
		GetComponent<Rigidbody>().isKinematic = true;
		moving = false;
		toDelete = true;

	}

	public void Shoot (){
	

	//	rigidbody.isKinematic = false;
		//rigidbody.WakeUp();

		Vector3 scatter = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y - 5, transform.eulerAngles.z);
		scatter.y = scatter.y + Random.Range (0,10);
	
		transform.eulerAngles = scatter;

		GetComponent<Rigidbody>().AddForce (power * transform.forward *Random.Range (0.7f,1f), ForceMode.Impulse);
		moving = true;

		//rigidbody.useGravity = true;
	}

	public void Shoot2(){

		GetComponent<Rigidbody>().velocity =power * transform.forward *Random.Range (0.7f,1f);

	}

}
