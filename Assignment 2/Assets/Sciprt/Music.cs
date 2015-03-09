using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour 
{

    public AudioClip Music1;
    public AudioClip Ambi1;


	// Use this for initialization
	void Awake () 
    {
        DontDestroyOnLoad(this.gameObject);
        if (Player.reg_vision)
            PlaySound(Music1, 0.3f);
        else if (Player.reg_vision == false)
            PlaySound(Ambi1, 0.3f);
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if (Player.reg_vision)
                PlaySound(Music1, 0.2f);
            else if (Player.reg_vision == false)
                PlaySound(Ambi1, 0.4f);
        }
	}

    void PlaySound(AudioClip m, float vol)
    {
        GetComponent<AudioSource>().clip = m;
        GetComponent<AudioSource>().volume = vol;
        GetComponent<AudioSource>().Play();
    }

}
