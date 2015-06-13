using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public GameObject player;
	public float distance = 15.0f;
	public float cameraSpeed = 5.0f;
	public float yMin = -20f;
	public float yMax = 80f;

	// Turning rate of the player when RMB is held
	public float turningRate = 60f;

	private float x;
	private float y;

	// Use this for initialization
	void Start () {
		x = transform.eulerAngles.x;
		y = transform.eulerAngles.y;
	}
	
	// Update is called once per frame
	void LateUpdate () { //late means runs after all processes updated
		y -= Input.GetAxis ("Mouse Y");
		x += Input.GetAxis ("Mouse X");

		y = ClampAngle (y, yMin, yMax);
		
		Quaternion rotation = Quaternion.Euler (y, x, 0);

		Vector3 position = rotation * new Vector3 (0.0f, 0.0f, -distance);
		
		transform.rotation = rotation;
		transform.position = player.transform.position + position;

		// If rmb held down, player rotation follows camera
		if (Input.GetMouseButton (1)) {
			Quaternion playerRotate = Quaternion.RotateTowards(
				player.transform.rotation,
				rotation,
				turningRate * Time.deltaTime
				);
			playerRotate = Quaternion.Euler(new Vector3(
				0.0f,
				playerRotate.eulerAngles.y,
				0.0f
				));
			player.transform.rotation = playerRotate;
		}
	}

	float ClampAngle(float angle, float min, float max) {
		if (angle < -360.0f) {
			angle += 360.0f;
		} else if (angle > 360.0f) {
			angle -= 360.0f;
		}
		return Mathf.Clamp(angle, min, max);
	}
}
