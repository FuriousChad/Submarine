using UnityEngine;
using System.Collections;

public class SubMovement : MonoBehaviour
{
	// public variables

	public float movementSpeed; // = 100f;
	public float rotationSpeed; // = 5f;
	public float maxSpeed;

	public GameObject[] propellers;
	public float propChangeRate;
	public ParticleSystem[] bubbles;

	public AudioClip hit;


	// private variables
	private float surfaceHeight = 450.2f;


	void Start()
	{
		rigidbody.freezeRotation = true;
	}
	

	void FixedUpdate()
	{
	
		if(transform.position.y < surfaceHeight)
		{
			if(Input.GetKey("w"))
			{
				up();
			}
		}

		if(Input.GetKey("s"))
		{
			down();
		}

		if(Input.GetKey("up"))
		{
			forward();
			foreach(GameObject prop in propellers)
			{	
				prop.animation.CrossFade("FastSpin", propChangeRate);
			}

			foreach(ParticleSystem bubble in bubbles)
			{
				bubble.emissionRate = 100f;
			}
		}

		else
		{
			foreach(GameObject prop in propellers)
			{	
				prop.animation.CrossFade("SlowSpin", propChangeRate);
			}

			foreach(ParticleSystem bubble in bubbles)
			{
				bubble.emissionRate = 10f;
			}
		}

		if(Input.GetKey("down"))
		{
			backward();
		}
		
		// Rotation
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
		rotate(rotation);


		// Keep in water
		if(transform.position.y >= surfaceHeight)
		{
			Vector3 temp = new Vector3(rigidbody.velocity.x, 0, rigidbody.velocity.z);
			rigidbody.velocity = temp;
		}
		
	}
	

	/***************************
	 Control Functions
	**************************/
	void up()
	{
		rigidbody.AddForce(Vector3.up * movementSpeed, ForceMode.Acceleration); 
	}

	void down()
	{
		rigidbody.AddForce(Vector3.down * movementSpeed, ForceMode.Acceleration); 	
	}

	void forward()
	{
		if(rigidbody.velocity.magnitude < maxSpeed)
			rigidbody.AddForce(transform.forward * movementSpeed, ForceMode.Acceleration);

	}

	void backward()
	{
		rigidbody.AddForce(-1 * transform.forward * movementSpeed, ForceMode.Acceleration);	
	}

	void rotate(float rotation)
	{
		rigidbody.freezeRotation = false;
		transform.Rotate(0, rotation, 0);
		rigidbody.freezeRotation = true;
	}

	void OnCollisionEnter(Collision collision)
	{
		audio.PlayOneShot(hit);
	}
	
}


