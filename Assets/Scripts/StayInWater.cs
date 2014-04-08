using UnityEngine;
using System.Collections;

public class StayInWater : MonoBehaviour {

	public float waterLevel;
	public float safeDistance;
	
	// Update is called once per frame
	void Update ()
	{
		if(rigidbody.position.y > waterLevel - safeDistance)
		{

			rigidbody.position = new Vector3(
				rigidbody.position.x,
				waterLevel - safeDistance,
				rigidbody.position.z);
				
		}
	}
}
