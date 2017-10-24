using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenFollow : MonoBehaviour {

	public Transform target;
	public Transform myTransform;
	public float moveSpeed = 6f;


	void Start () {

		target = GameObject.FindWithTag("Player").transform;
		
	}
	

	void Update () {

		transform.LookAt (target);
		transform.Translate (Vector3.forward * Time.deltaTime * moveSpeed);
		
	}
}
