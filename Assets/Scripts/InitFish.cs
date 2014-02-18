using UnityEngine;
using System.Collections;

public class InitFish : MonoBehaviour {

	private int spawnAmount;
	private int spawnX, spawnY, spawnZ;
	public Transform fish;
	
	// Use this for initialization
	void Start ()
	{
		spawnAmount = Random.Range(100,200);
		
		for(int i=0; i<spawnAmount; i++)
		{
			spawnX = Random.Range(-1000, 1000);
			spawnY = Random.Range(-1000, 1000);
			spawnZ = Random.Range(-1000, 1000);
			Instantiate(fish, new Vector3(spawnX, spawnY, spawnZ), Quaternion.identity);	
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}




