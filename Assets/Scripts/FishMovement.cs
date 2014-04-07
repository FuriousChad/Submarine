using UnityEngine;
using System.Collections;

public class FishMovement : MonoBehaviour {
	
	void Update ()
	{
		UpdateFacingDirection();
	}

	void UpdateFacingDirection()
	{
		this.transform.rotation = Quaternion.LookRotation(rigidbody.velocity, Vector3.up);
	}
}
