using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	void Start()
	{
		guiTexture.enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (master.fishCaught >= 25)
		{
			Time.timeScale = 0;
			guiTexture.enabled = true;

			if(Input.GetKey(KeyCode.R))
			{
				Time.timeScale = 1;
			   	Application.LoadLevel("Scene1");
			}
		}
	}
}
