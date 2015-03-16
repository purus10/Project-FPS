using UnityEngine;
using System.Collections;

public class Footsteps : MonoBehaviour 
{

    public AudioClip[] footsteps;
    public float nextFoot;

	// Use this for initialization
	IEnumerator Start () 
    {
	    CharacterController controller = GetComponent<CharacterController>();
        while(true)
        {
            if(controller.isGrounded && controller.velocity.magnitude >0.2F)
            {
                PlaySound(footsteps[Random.Range(0,footsteps.Length)], 0.1f);
                yield return new WaitForSeconds(nextFoot);
            }   
            else
            {
                yield return 0;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void PlaySound(AudioClip a, float vol)
    {
        GetComponent<AudioSource>().clip = a;
        GetComponent<AudioSource>().volume = vol;
        GetComponent<AudioSource>().Play();
    }
}
