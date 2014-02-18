#pragma strict

var movementSpeed : float = 1000;
var surfaceHeight : float = 448.2;

private var atSurface : boolean = false;


function Update ()
{
	/***************
	 Movement
	***************/
	
	if(Input.GetKey("w"))
	{
		if(transform.position.y < surfaceHeight)
			rigidbody.AddForce(Vector3.up * movementSpeed, ForceMode.Impulse); 
			//rigidbody.velocity = Vector3(0,1,0)*movementSpeed;
	}
	if(Input.GetKey("s"))
	{
		rigidbody.AddForce(Vector3.down * movementSpeed, ForceMode.Impulse); 
		//rigidbody.velocity = Vector3(0,-1,0)*movementSpeed;
	}
	if(Input.GetKey("a"))
	{
		rigidbody.AddForce(Vector3.left * movementSpeed, ForceMode.Impulse);
		//rigidbody.velocity = Vector3(-1,0,0)*movementSpeed;
	}
	if(Input.GetKey("d"))
	{
		rigidbody.AddForce(Vector3.right * movementSpeed, ForceMode.Impulse);
		//rigidbody.velocity = Vector3(1,0,0)*movementSpeed;
	}
	if(Input.GetKey("up"))
	{
		rigidbody.AddForce(Vector3.forward * movementSpeed, ForceMode.Impulse);
		//rigidbody.velocity = Vector3(0,0,1)*movementSpeed;
	}
	if(Input.GetKey("down"))
	{
		rigidbody.AddForce(Vector3.back * movementSpeed, ForceMode.Impulse);
		//rigidbody.velocity = Vector3(0,0,-1)*movementSpeed;
	}
	if(Input.GetKey("space"))
	{
		//rigidbody.AddForce(Vector3.back * movementSpeed);
		rigidbody.velocity = Vector3(0,0,0);
	}		
	
	//Debug.Log("Velocity: (" + rigidbody.velocity.x + ", " + rigidbody.velocity.y + ", " + rigidbody.velocity.z + ").");
	
	/***************
	 World Boundaries
	***************/
	var currentX = transform.position.x;
	var currentY = transform.position.y;
	var currentZ = transform.position.z;
	
	if(currentX >= 1000)
		transform.position = Vector3(1000, currentY, currentZ);
	if(currentX <= -1000)
		transform.position = Vector3(-1000, currentY, currentZ);
		
	if(currentZ >= 1000)
		transform.position = Vector3(currentX, currentY, 1000);
	if(currentZ <= -1000)
		transform.position = Vector3(currentX, currentY, -1000);
		
	//if(currentY >= surfaceHeight)
	//	transform.position = Vector3(currentX, surfaceHeight-.1, currentZ);
	
}