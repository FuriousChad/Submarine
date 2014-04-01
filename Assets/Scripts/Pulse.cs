/* Used to make a light (point light)
 * flash on and off from 0 to maxIntensity
 * at rate of speed
*/

using UnityEngine;
using System.Collections;

public class Pulse : MonoBehaviour {

	public float speed;
	public float maxIntensity;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		light.intensity = Mathf.PingPong(Time.time * speed, maxIntensity);
	}
}


