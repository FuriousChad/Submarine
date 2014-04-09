using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
	public Rigidbody projectile;
	public float speed;
	public float fireRate;

	private float nextFire;


	void Update() {
		if (Input.GetKey(KeyCode.Space) && Time.time >= nextFire)
		{
			nextFire = Time.time + fireRate;
			Rigidbody clone;
			clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
			clone.velocity = transform.TransformDirection(Vector3.forward * speed);
		}
	}

}
