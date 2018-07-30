using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class StickControlforSteamVR : MonoBehaviour
{
	private float _mMoveSpeed = 2.5f;
	private float _mHorizontalTurnSpeed = 180f;
	private float _mVerticalTurnSpeed = 2.5f;
	private bool _mInverted = false;
	private const float VERTICAL_LIMIT = 60f;

	private void OnGUI()
	{
		Player player = Player.instance;
		if (!player)
		{
			return;
		}

		EVRButtonId touchPad = EVRButtonId.k_EButton_SteamVR_Touchpad;

		if (null != player.leftController)
		{
			var touchPadVector = player.leftController.GetAxis(touchPad);
			GUILayout.Label(string.Format("Left X: {0:F2}, {1:F2}", touchPadVector.x, touchPadVector.y));
		}

		if (null != player.rightController)
		{
			var touchPadVector = player.rightController.GetAxis(touchPad);
			GUILayout.Label(string.Format("Right X: {0:F2}, {1:F2}", touchPadVector.x, touchPadVector.y));
		}
	}

	float GetAngle(float input)
	{
		if (input < 0f)
		{
			return -Mathf.LerpAngle(0, VERTICAL_LIMIT, -input);
		}
		else if (input > 0f)
		{
			return Mathf.LerpAngle(0, VERTICAL_LIMIT, input);
		}
		return 0f;
	}

	// Update is called once per frame
	void Update()
	{
		Player player = Player.instance;
		if (!player)
		{
			return;
		}

		EVRButtonId touchPad = EVRButtonId.k_EButton_SteamVR_Touchpad;

		if (null != player.leftController)
		{
			Quaternion orientation = Camera.main.transform.rotation;
			var touchPadVector = player.leftController.GetAxis(touchPad);
			Vector3 moveDirection = orientation * Vector3.forward * touchPadVector.y + orientation * Vector3.right * touchPadVector.x;
			Vector3 pos = player.transform.position;
			pos.x += moveDirection.x * _mMoveSpeed * Time.deltaTime;
			pos.z += moveDirection.z * _mMoveSpeed * Time.deltaTime;
			player.transform.position = pos;
		}

		if (null != player.rightController)
		{
			Quaternion orientation = player.transform.rotation;
			var touchPadVector = player.rightController.GetAxis(touchPad);

			Vector3 euler = transform.rotation.eulerAngles;
			float angle;
			if (_mInverted)
			{
				angle = GetAngle(touchPadVector.y);
			}
			else
			{
				angle = GetAngle(-touchPadVector.y);
			}
			euler.x = Mathf.LerpAngle(euler.x, angle, _mVerticalTurnSpeed * Time.deltaTime);
			euler.y += touchPadVector.x * _mHorizontalTurnSpeed * Time.deltaTime;
			player.transform.rotation = Quaternion.Euler(euler);
		}
	}
}
