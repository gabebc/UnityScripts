using UnityEngine;
using System.Collections;

public class BasicCharacterController : MonoBehaviour {

	private Animator myAnimator;

	// Use this for initialization
	void Start () {
		myAnimator = GetComponent<Animator> ();
	}

	void Update () {
		myAnimator.SetFloat ("VSpeed", Input.GetAxis ("Vertical"));
		myAnimator.SetFloat ("HSpeed", Input.GetAxis ("Horizontal"));

		if (Input.GetButtonDown ("Jump")) {
			myAnimator.SetBool ("Jumping", true);
			Invoke ("StopJumping", .1f);
		}
    if (Input.GetKey ("q")) {
			transform.Rotate (Vector3.down * Time.deltaTime * 100.0f);
		}
		if (Input.GetKey ("e")) {
			transform.Rotate (Vector3.up * Time.deltaTime * 100.0f);
		}

	}
	void StopJumping (){
		myAnimator.SetBool ("Jumping", false);
	}
}
