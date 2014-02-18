#pragma strict

var fishSpeed : int = 30;
var direction : Vector3; 
var targetVelocity : Vector3;
var currentVelocity : Vector3;


function Awake ()
{
	 currentVelocity = (new Vector3(Random.Range(-1,1), Random.Range(-1,1), Random.Range(-1,1))) * fishSpeed;
	 targetVelocity = currentVelocity;
	  //direction = (new Vector3(Random.Range(-1.0f, 1.0f), 0.0f, Random.Range(-1.0f, 1.0f))).normalized;		
}

function Update()
{
	// move fish	
	transform.position += currentVelocity * Time.deltaTime;

	// rotate fish
	transform.rotation = Quaternion.LookRotation(transform.position, Vector3.up);

	
	
}
