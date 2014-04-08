using UnityEngine;
using System.Collections;

public class MuteAll : MonoBehaviour
{
	public Texture2D mutedTexture;
	public Texture2D unmutedTexture;

	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.M))
		{
			AudioListener.pause = !AudioListener.pause;
		}
	}

	void OnGUI()
	{
		bool muted = AudioListener.pause;

		if(!muted)
		{
			if (GUI.Button(new Rect(Screen.width - 70, Screen.height-60, 70, 50), "Mute"))
			{
				AudioListener.pause = !AudioListener.pause;
			}
		}
		else
		{
			if (GUI.Button(new Rect(Screen.width - 70, Screen.height-60, 70, 50), "Unmute"))
			{
				AudioListener.pause = !AudioListener.pause;
			}
		}
	}
}

