using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{


	public float speed;
	public Rigidbody projectile;

	void Update() {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Rigidbody clone;
			clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
			clone.velocity = transform.TransformDirection(Vector3.forward * speed);
		}
	}

}
