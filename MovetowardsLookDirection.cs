using UnityEngine;
using System.Collections;

public class MovetowardsLookDirection : MonoBehaviour {
	public float distance = 5;

	void Update() {
		transform.position = transform.position + new Vector3 (Camera.main.transform.forward.x * distance * Time.deltaTime, 0, Camera.main.transform.forward.z * distance * Time.deltaTime);
	
	}
}
