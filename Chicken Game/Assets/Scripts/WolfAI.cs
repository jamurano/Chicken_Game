using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI : MonoBehaviour {
<<<<<<< HEAD

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
=======
	public Rigidbody enemy;
	public Rigidbody enemy2;
	public float moveSpeed;
	public Transform target;

	void OnTriggerStay(Collider other){

		if(other.gameObject.name == "Player"){
			Debug.Log("Player has entered wolfs trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
		if(other.gameObject.name == "Chicken"){
			Debug.Log("Chicken has entered wolfs trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
	}
}


>>>>>>> master
