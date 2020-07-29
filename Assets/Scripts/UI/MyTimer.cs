using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class MyTimer : MonoBehaviour
{
	public float initialTime = 60f;
	private DateTime timerEnd;
	public Text timerText;
	public LevelLoader loader;
	public Restart restart;
	public AudioSource sound;

	void Start()
	{
		timerEnd = DateTime.Now.AddSeconds(initialTime);
	}

	void Update()
	{
		TimeSpan delta = timerEnd - DateTime.Now;
		if (delta.TotalSeconds <= 0)
		{
			if (sound != null)
            {
				sound.Play();
			}
			GameOver();
		}
		if (timerText != null)
        {
			timerText.text = delta.Minutes.ToString("00") + ":" + delta.Seconds.ToString("00");
		}
	}

	void GameOver()
    {
		if (loader != null)
        {
			loader.NextLevel();
        };
		if (restart != null)
		{
			restart.GoToStart();
		};

		timerEnd = DateTime.Now.AddSeconds(initialTime);
	}
}