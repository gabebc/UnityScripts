using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTriggerAnimation : MonoBehaviour {

	public Animator anim;

	void Start(){
	anim = GetComponent<Animator>();

}
	
	void Update(){
		if(Input.GetMouseButton(0)) //only shoot out ray when you press mouse button
		{
			RaycastHit hit; //store information if you hit something
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //use camera to create ray at mouse position


			if(Physics.Raycast(ray, out hit))
			{
				anim.Play("cubespin");
			}
		}

}
}
