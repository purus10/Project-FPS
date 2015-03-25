using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour 
{

    public AudioSource Musical;
    public AudioSource Ambi;


	// Use this for initialization
	void Awake () 
    {
        DontDestroyOnLoad(this.gameObject);
        if (Player.reg_vision)
        {
            Musical.Play();
            Musical.volume = 0.5f;
            Ambi.Play();
            Ambi.volume = 0.0f;
        }
        else if (!Player.reg_vision)
        {
            Musical.Play();
            Musical.volume = 0.0f;
            Ambi.Play();
            Ambi.volume = 0.7f;
        }
	}
	
	// Update is called once per frame
	void Update () 
    {

            if (Player.reg_vision)
            {
                Musical.volume = 0.5f;
                Ambi.volume = 0.0f;
            }
            else if (!Player.reg_vision)
            {
                Musical.volume = 0.0f;
                Ambi.volume = 0.7f;
            }
        
	}
}
