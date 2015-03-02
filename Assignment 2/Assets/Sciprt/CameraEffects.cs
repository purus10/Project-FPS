using UnityEngine;
using System.Collections;

public class CameraEffects : MonoBehaviour {

	public Color mask_on, mask_off;

	void Start()
	{
		mask_off = camera.backgroundColor;
	}

	//Changes camera background when maskon
	void FixedUpdate () {
	
		if (!Player.reg_vision) camera.backgroundColor = mask_on;
		else camera.backgroundColor = mask_off;
	}
}
