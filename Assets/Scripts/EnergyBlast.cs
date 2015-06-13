using UnityEngine;
using System.Collections;

public class EnergyBlast : MonoBehaviour {
	public Rigidbody projectileD;
	private Vector3 offset;
	private Vector3 fwd;
	void Update() {
		if (Input.GetKey(KeyCode.RightShift)) {
			fwd = transform.TransformDirection(Vector3.forward);
			offset = transform.position + fwd;
			Rigidbody clone;
			clone = Instantiate(projectileD, offset, transform.rotation) as Rigidbody;
			clone.velocity = transform.TransformDirection(Vector3.forward * 10);
			Object.Destroy (projectileD,2.0f);
		}
	}
}