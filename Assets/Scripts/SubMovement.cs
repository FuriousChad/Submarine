using UnityEngine;
using System.Collections;

public class SubMovement : MonoBehaviour
{
	// public variables

	public float movementSpeed; // = 100f;
	public float rotationSpeed; // = 5f;
	public float maxSpeed;
	public GameObject propeller1;
	public GameObject propeller2;
	public GameObject propeller3;
	public GameObject propeller4;
	public AudioClip hit;
	
	//public AnimationClip slowAnimationClip;
	//public AnimationClip fastAnimationClip;
	public ParticleSystem bubbles1;
	public ParticleSystem bubbles2;
	public ParticleSystem bubbles3;
	public ParticleSystem bubbles4;
	

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

			propeller1.animation.CrossFade("FastSpin", 0.5f);
			propeller2.animation.CrossFade("FastSpin", 0.5f);
			propeller3.animation.CrossFade("FastSpin", 0.5f);
			propeller4.animation.CrossFade("FastSpin", 0.5f);
			

			bubbles1.emissionRate = 100f;
			bubbles2.emissionRate = 100f;
			bubbles3.emissionRate = 100f;
			bubbles4.emissionRate = 100f;
			
		}
		else
		{
			propeller1.animation.CrossFade("SlowSpin", 0.5f);
			propeller2.animation.CrossFade("SlowSpin", 0.5f);
			propeller3.animation.CrossFade("SlowSpin", 0.5f);
			propeller4.animation.CrossFade("SlowSpin", 0.5f);

			bubbles1.emissionRate = 10f;
			bubbles2.emissionRate = 10f;
			bubbles3.emissionRate = 10f;
			bubbles4.emissionRate = 10f;
			
			
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


