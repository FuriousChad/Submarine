#pragma strict
var waterHeight : float = 334;
var bubbleParticles : ParticleSystem;
private var isUnderWater : boolean;
private var normalColor : Color;
private var waterColor : Color;


function Start ()
{
	normalColor = new Color (0.5f, 0.5f, 0.5f, 0.5f);
	waterColor = new Color (0.22f, 0.65f, 0.77f, 0.5f);
	
}

function Update ()
{
	//if((transform.parent.gameObject.transform.position.y > waterHeight))
	//{
		isUnderWater = transform.position.y < waterHeight;
		if(isUnderWater) SetUnderWater();
		else SetNormal();
	//}
}


function SetNormal()
{
	RenderSettings.fogColor = normalColor;
	RenderSettings.fogDensity = 0.002f;
	bubbleParticles.active = false;

}

function SetUnderWater()
{
	RenderSettings.fogColor = waterColor;
	RenderSettings.fogDensity = 0.003;
	bubbleParticles.active=true;
	rigidbody.drag = 0;
}
