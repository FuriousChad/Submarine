using UnityEngine;
using System.Collections;

public class master : MonoBehaviour {

	public Texture2D fullscreenTexture;
	public Texture2D unfullscreenTexture;

	public static int fishCaught;

	void Start()
	{
		fishCaught = 0;
	}

	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.F))
		{
			Screen.fullScreen = !Screen.fullScreen;
		}
	}

	void OnGUI()
	{

		// FishCaught
		GUI.Box(new Rect(Screen.width - 110, 10, 100, 30), "Fish caught: " + fishCaught);




		// Fullscreen toggle 
		bool full = Screen.fullScreen;
		
		if(!full)
		{
			if (GUI.Button(new Rect(Screen.width - 140, Screen.height-60, 70, 50), "Full"))
			{
				Screen.fullScreen = !Screen.fullScreen;
			}
		}
		else
		{
			if (GUI.Button(new Rect(Screen.width - 140, Screen.height-60, 70, 50), "Exit Full"))
			{
				Screen.fullScreen = !Screen.fullScreen;
			}
		}

	}
}
