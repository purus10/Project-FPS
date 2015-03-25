using UnityEngine;
using System.Collections;

public class PressFOculus : MonoBehaviour {

	public TextMesh pressbutton;
	int t;
	public bool fade = true;

	void Update () 
	{
		if (Player.reg_vision == false) pressbutton.GetComponent<Renderer>().enabled = false;
		else{
			if (fade == true && Player.reg_vision == true)
			{
				t++;
				pressbutton.color = Color.Lerp(pressbutton.color,Color.clear,Time.time);
				if (t == 55) fade = false;
			}

			if (fade == false && Player.reg_vision == true) 
			{
				t--;
				pressbutton.color = Color.Lerp(pressbutton.color,Color.black,Time.time);
				if (t == 0) fade = true;
			}
		}
	}

	void OnTriggerEnter()
	{
        if(Player.reg_vision == false)
            Application.LoadLevel("SampleLevel - Oculus");
            Player.reg_vision = true;
	}
}