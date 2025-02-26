﻿using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour
{

	public GUITexture button;
	public Texture2D mutedTexture;
	public Texture2D unmutedTexture;

	void Start()
	{
		audio.pitch = -0.8f;
	}
	void Update()
	{
		if(Input.GetKey(KeyCode.UpArrow))
		{
			audio.pitch += 0.01f;
			if(audio.pitch >= 1.2f)
			{
				audio.pitch = 1.2f;
			}
		}
		
		if(Input.GetKey(KeyCode.UpArrow) == false)
		{
			audio.pitch -= 0.01f;
			if(audio.pitch <= 0.8f)
			{
				audio.pitch = 0.8f;
			}
		}

	}
}
