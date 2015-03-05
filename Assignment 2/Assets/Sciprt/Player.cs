using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	static public bool reg_vision = true;
	public GameObject monster;
	public KeyCode mask_button;
	
	void Mask()
	{
		Transform[] search = GameObject.FindObjectsOfType(typeof(Transform)) as Transform[];
		
		foreach (Transform t in search) 
		{
			Visible v = t.GetComponent<Visible>();
			if (t.GetComponent<Renderer>() != null && v == null && t.name != monster.name) t.GetComponent<Renderer>().enabled = reg_vision;
		}
	}

	// Input button to put mask on and renderers appropriate objects.
	void FixedUpdate () 
	{
		if (Input.GetKeyDown(mask_button))
		{
			if (reg_vision) reg_vision = false;
			else reg_vision = true;

			Mask();
		}
	}
}
