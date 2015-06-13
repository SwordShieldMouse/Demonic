using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float moveSpeed;
	public float flightSpeed;
	public float jumpSpeed;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		// Movement
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		Vector3 moveVector = new Vector3 (horizontal, vertical, 0) * moveSpeed;
		rb.AddForce (moveVector);

		// Jumping

	}

	void FixedUpdate() {

	}
}
