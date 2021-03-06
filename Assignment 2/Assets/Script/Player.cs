﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	static public bool reg_vision = true;
	public GameObject monster;
	public AudioClip clip; //<--- you need this to drag the audio on in inspector;
	public KeyCode mask_button;
	public GameObject[] door;
    private bool m_isAxisInUse = false;

	void Start()
	{
		foreach (GameObject d in door)
		{
			int Bool = Random.Range(0,2);
			if (Bool == 1) d.GetComponent<Collider>().enabled = true;
		}
	}

	void PlaySound(AudioClip a, float vol)
	{
		GetComponent<AudioSource>().clip = a;
		GetComponent<AudioSource>().volume = vol;
		GetComponent<AudioSource>().Play();
	}

	//example of hoe you would write it in /***PlaySound(clip, 10f);***/
	
	void Mask()
	{
		Transform[] search = GameObject.FindObjectsOfType(typeof(Transform)) as Transform[];
		
		foreach (Transform t in search) 
		{
			Visible v = t.GetComponent<Visible>();
			if (t.GetComponent<Renderer>() != null && v == null && t.name != monster.name) t.GetComponent<Renderer>().enabled = reg_vision;
		}
	}

	// Input button to put mask on and renderers appropriate objects.
	void FixedUpdate () 
	{
        if (Input.GetKeyDown(mask_button) || Input.GetAxis("RBumper") != 0)
		{
                if(m_isAxisInUse == false)
                {
                    if (reg_vision) reg_vision = false;
                    else reg_vision = true;
                    Mask();
                    m_isAxisInUse = true;
                }
	//		if (reg_vision) reg_vision = false;
	//		else reg_vision = true;
	//		Mask();
		}
        if (Input.GetAxis("RBumper") == 0)
        {
            m_isAxisInUse = false;
        }
	}
    //
}
