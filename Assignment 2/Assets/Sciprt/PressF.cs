using UnityEngine;
using System.Collections;

public class PressF : MonoBehaviour {

	public TextMesh pressf;
	int t;
	public bool fade = true;

	void Update () 
	{
		if (Player.reg_vision == false) pressf.GetComponent<Renderer>().enabled = false;
		else{
			if (fade == true && Player.reg_vision == true)
			{
				t++;
				pressf.color = Color.Lerp(pressf.color,Color.clear,Time.time);
				if (t == 55) fade = false;
			}

			if (fade == false && Player.reg_vision == true) 
			{
				t--;
				pressf.color = Color.Lerp(pressf.color,Color.black,Time.time);
				if (t == 0) fade = true;
			}
		}
	}

	void OnTriggerEnter()
	{
        if(Player.reg_vision == false)
            Application.LoadLevel("FeatureTest");
            Player.reg_vision = true;
	}
}
