using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

	void OnTriggerEnter(Collider fun)
	{

		if (fun.tag == "Player")
			Application.LoadLevel("EndGame");
		Player.reg_vision = true;
	}
}
