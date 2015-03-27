using UnityEngine;
using System.Collections;

public class CameraEffects : MonoBehaviour {

	public Color mask_on;
	private Color mask_off;

	void Start()
	{
		UnityEngine.Cursor.visible = false;
		mask_off = GetComponent<Camera>().backgroundColor;
	}

	//Changes camera background when maskon
	void FixedUpdate () {
		if (!Player.reg_vision) GetComponent<Camera>().backgroundColor = mask_on;
		else GetComponent<Camera>().backgroundColor = mask_off;
	}
}
