using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {
	

	// Update is called once per frame
		void Update()
		{
			if (Input.anyKeyDown)
			{
				Application.Quit();
			}
		}
}
