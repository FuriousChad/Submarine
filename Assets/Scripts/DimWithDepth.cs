using UnityEngine;
using System.Collections;

public class DimWithDepth : MonoBehaviour
{	
	public Transform subPosition;

	private float lightMin;
	private float lightMax;
	private float positionMin;
	private float positionMax;

	// Use this for initialization
	void Start ()
	{
		light.intensity = 0.5f;
		lightMin = 0.05f;
		lightMax = 0.5f;
		positionMin = 2.0f;
		positionMax = 447.0f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		float lightIntensity;
		// linear interpolation with sub position and light intensity
		lightIntensity = lightMin + (lightMax - lightMin) 
			* (subPosition.position.y - positionMin) 
			/ (positionMax - positionMin); 

		light.intensity = lightIntensity;
	}
}
