using UnityEngine;
using System.Collections;

public class FishMovement : MonoBehaviour {

	//public float fishSpeed;

	// Use this for initialization
	void Start ()
	{
		//fishSpeed = 50.0f;

		//rigidbody.velocity = (new Vector3(Random.Range(-1,1), Random.Range(-1,1), Random.Range(-1,1))) * fishSpeed;
	}
	
	// Update is called once per frame
	void Update ()
	{
		UpdateFacingDirection();
	}

	void UpdateFacingDirection()
	{
		this.transform.rotation = Quaternion.LookRotation(rigidbody.velocity, Vector3.up);
	}
}
