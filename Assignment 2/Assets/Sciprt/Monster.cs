using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {

	public Transform player;
	public Color mask_off, mask_on;

	// Changes monsters color and has it face the character when mask on.
	void FixedUpdate () 
	{
		if (Player.reg_vision) renderer.material.color = mask_off;
		else{ 
			renderer.material.color = mask_on;
			transform.LookAt(player);
		}
	}
}
