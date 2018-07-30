using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTriggerAnimation : MonoBehaviour {

	public Animator anim;

	void Start(){
	anim = GetComponent<Animator>();

}
	
	void Update(){
		if (Input.GetKeyDown("1"))
			{
			anim.Play ("youranimationname1");
			}
		if (Input.GetKeyDown("2"))
		{
			anim.Play ("youranimationname2");
		}
	
	}

}
