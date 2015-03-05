using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {

	public Transform player;
	public Color mask_on;
	private Color mask_off;

	void Start()
	{
		mask_off = GetComponent<Renderer>().material.color;
	}

	// Changes monsters color and has it face the character when mask on.
	void FixedUpdate () 
	{
		if (Player.reg_vision) GetComponent<Renderer>().material.color = mask_off;
		else{ 
			GetComponent<Renderer>().material.color = mask_on;
			transform.LookAt(player);
		}
	}
}
