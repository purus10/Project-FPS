using UnityEngine;
using System.Collections;

public class Pit : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter (Collider cat) 
	{
        if (cat.tag == "Player") 
		Application.LoadLevel("StartMenu - Oculus");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
