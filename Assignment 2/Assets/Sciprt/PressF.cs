using UnityEngine;
using System.Collections;

public class PressF : MonoBehaviour {

	public TextMesh pressf;
	
	void Update () 
	{
		if (Player.reg_vision == false)
		{
			pressf.GetComponent<Renderer>().enabled = false;
		}
	}

	void OnTriggerEnter()
	{
		Application.LoadLevel("FeatureTest");
		Player.reg_vision = true;
	}
}
