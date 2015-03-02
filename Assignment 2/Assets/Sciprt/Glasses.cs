using UnityEngine;
using System.Collections;

public class Glasses : MonoBehaviour {
	
	public int Pre_min, Pre_max;

	int perscription()
	{
		return Random.Range(Pre_min,Pre_max);
	}

	void OnTriggerEnter(Collider col)
	{
		//generates the glasses perscription number then destroys self;
		Player player = col.GetComponent<Player>();
		player.perscription = perscription();
		Destroy(this.gameObject);
	}
}
