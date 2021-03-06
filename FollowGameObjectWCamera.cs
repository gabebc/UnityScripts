// FOLLOW A CHARACTER OR OBJECT WITH A CAMERA
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGameObjectWCamera : MonoBehaviour {
	{
		public Transform target;
		public Vector3 offset = new Vector3(0f, 7.5f, 0f);

		//LateUpdate is called after Update is finished so the camera follows the character
		private void LateUpdate()
		{
			transform.position = target.position + offset;
		}
	}
}
