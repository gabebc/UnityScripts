using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroybyName : MonoBehaviour {

	public void OnCollisionEnter (Collision collision)

	{
		if(collision.gameObject.name == "yourname")
		{
			Destroy(collision.gameObject);
		}
	}
}
