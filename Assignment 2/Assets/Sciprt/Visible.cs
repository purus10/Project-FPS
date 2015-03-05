using UnityEngine;
using System.Collections;

public class Visible : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		if (!Player.reg_vision)
			GetComponent<Renderer>().enabled = true;
		else
			GetComponent<Renderer>().enabled = false;
	
	}
}
