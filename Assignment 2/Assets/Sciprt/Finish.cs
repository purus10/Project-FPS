﻿using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.F))
			{
				Application.Quit();
			}
		}
}
