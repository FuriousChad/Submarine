﻿using UnityEngine;
using System.Collections;

public class master : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.F))
		{
			Screen.fullScreen = !Screen.fullScreen;
		}
	}
}
