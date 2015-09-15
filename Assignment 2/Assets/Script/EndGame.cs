using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

	void OnTriggerEnter()
	{
		if(Player.reg_vision == false)
			Application.LoadLevel("EndGame");
		Player.reg_vision = true;
	}
}
