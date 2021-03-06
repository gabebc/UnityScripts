using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollideDestroy : MonoBehaviour {
	public AudioSource source;
	public AudioClip clip;

	void Start(){
		source = GetComponent<AudioSource> ();
	}
	public void OnCollisionEnter (Collision collision){
		
		if (collision.gameObject.name == "player") {
			AudioSource.PlayClipAtPoint (clip, transform.position, 3f);
			Destroy (gameObject);
		}
	}
}
