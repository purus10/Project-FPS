using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {
	
	public float wait_frames;
	public float mask_speed, run_speed;
	public Transform player;

	public float t;
	NavMeshAgent agent;
	Color mask_off;

	void Start()
	{
		mask_off = GetComponent<SpriteRenderer>().color;
		agent = GetComponent<NavMeshAgent>();
	}

	// If player in range chase player with run_speed
	void OnTriggerStay(Collider col)
	{
		agent.speed = run_speed;
		if (col.gameObject == player.gameObject) agent.SetDestination(col.transform.position);
	}

	//if touch game over
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject == player.gameObject) Application.LoadLevel("StartMenu");
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
