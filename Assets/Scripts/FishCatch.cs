using UnityEngine;
using System.Collections;

public class FishCatch : MonoBehaviour
{
	public GameObject catchPrefab;

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.CompareTag("Fish"))
		{
			Debug.Log("Hit a fish");

			Instantiate(catchPrefab, other.transform.position, other.transform.rotation);

			master.fishCaught++;
			Destroy(other.gameObject);
			Destroy(this.gameObject);
		}
	}
}
