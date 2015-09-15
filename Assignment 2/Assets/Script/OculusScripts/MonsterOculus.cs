using UnityEngine;
using System.Collections;

public class MonsterOculus: MonoBehaviour {
	
	public float wait_frames,wait_path,wait_screech;
	public float mask_speed, run_speed,walk_speed;
	public Transform player;
	public Transform[] walk_points;
	public AudioClip screech, caught;
	public float t,p,s;
	NavMeshAgent agent;
	Color mask_off;

	void Start()
	{
		mask_off = GetComponent<SpriteRenderer>().color;
		agent = GetComponent<NavMeshAgent>();
	}

	void PlaySound(AudioClip a, float vol)
	{
		GetComponent<AudioSource>().clip = a;
		GetComponent<AudioSource>().volume = vol;
		GetComponent<AudioSource>().Play();
	}

	// If player in range chase player with run_speed
	void OnTriggerStay(Collider col)
	{

		if (col.gameObject == player.gameObject) 
		{
			agent.speed = run_speed;
			agent.SetDestination(col.transform.position);
		} else {
			if (s > wait_screech) 
			{
				GetComponent<AudioSource>().PlayOneShot(screech,6);
				s = 0;
				wait_screech = Random.Range(0,1000) + wait_screech;
			}
		}
	}

	void PathCreate(int c)
	{
		agent.speed = walk_speed;
		agent.SetDestination(walk_points[c].transform.position);
	}

	//if touch game over
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject == player.gameObject) 
		{
			GetComponent<AudioSource>().PlayOneShot(caught,5);
			Application.LoadLevel("StartMenu - Oculus");
		}
	}

	//When mask on waits for a while then starts chasing the player with mask_speed.
	void Update()
	{
		if (Player.reg_vision == false)
		{
			t++;
			agent.speed = mask_speed;
			if (t >= wait_frames) agent.SetDestination(player.position);
		}else  if (t > 0) t--;

		p++;
		if (p > wait_path) 
		{
			PathCreate(Random.Range(0,walk_points.Length));
			p = 0;
		}

		s++;

	}

	// Changes monsters color and has it face the character when mask on.
	void FixedUpdate () 
	{
		if (Player.reg_vision) GetComponent<SpriteRenderer>().color = mask_off;
		else{ 
			GetComponent<SpriteRenderer>().color = Color.cyan;
			transform.LookAt(player);
		}
	}
}
