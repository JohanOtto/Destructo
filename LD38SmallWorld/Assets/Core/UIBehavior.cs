﻿using System;
using UnityEngine;

public abstract class UIBehavior: BehaviorBase
{
	public float updateInterval = 0.2f;

	private float resumeTime = 0f;


	void LateUpdate()
	{
		if (Time.time < resumeTime)
			return;

		resumeTime = Time.time + updateInterval;

		UpdateUI();
	}

	protected abstract void UpdateUI();

}

