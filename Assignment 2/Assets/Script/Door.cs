using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	Color door;

	void Start()
	{
		door = GetComponent<Renderer>().material.color;
	}
	
	void Update () {
		if (!Player.reg_vision && GetComponent<Collider>().enabled == false) 
		{
			GetComponent<Renderer>().enabled = true;
			GetComponent<Renderer>().material.color = Color.white;
		}
        else
        { 
			GetComponent<Renderer>().material.color = door;
		}
	}
}
