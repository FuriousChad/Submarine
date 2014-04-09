using UnityEngine;
using System.Collections;

public class CollisionParticles : MonoBehaviour
{
	public GameObject splashPrefab;

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			Debug.Log("Player hit the terrain");
			Vector3 splashPoint=other.transform.position;
			Instantiate(splashPrefab,splashPoint,other.transform.rotation);
		}
	}
}
