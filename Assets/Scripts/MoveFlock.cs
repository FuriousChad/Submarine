using UnityEngine;
using System.Collections;

public class MoveFlock : MonoBehaviour {

	// Use this for initialization

	void Start ()
	{
		float speed = 15f;
		rigidbody.velocity =  (new Vector3(Random.Range(-1,1), Random.Range(-1,1), Random.Range(-1,1))) * speed;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
