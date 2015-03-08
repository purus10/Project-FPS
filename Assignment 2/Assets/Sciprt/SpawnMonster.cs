using UnityEngine;
using System.Collections;

public class SpawnMonster : MonoBehaviour {

	public GameObject monster;
	public Transform spawnpoint;

	void OnTriggerEnter()
	{

		if(Player.reg_vision == true) 
		{
			print ("SPANW");
			monster.transform.position = spawnpoint.position;
		}
	}
}
