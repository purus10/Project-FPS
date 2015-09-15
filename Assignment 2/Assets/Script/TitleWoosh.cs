using UnityEngine;
using System.Collections;

public class TitleWoosh : MonoBehaviour {

    public AudioClip woosh;

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player" && GetComponent<Renderer>().enabled == true)
            AudioSource.PlayClipAtPoint(woosh, transform.position);
    }
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
