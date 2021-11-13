﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text timerText;
	private float startTime;
	private bool finnished;
	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (finnished)
			return;

		float t = Time.time - startTime		;
		string minutes = ((int)t / 60).ToString();
		string seconds = (t % 60).ToString("f2");
		timerText.text = minutes + ":" + seconds;
	}
	public void Finnish()

	{   if (timerText.text == 1 + ":" + 0.00)
		{
			finnished = true;
			timerText.color = Color.white;
		}
	}
}
