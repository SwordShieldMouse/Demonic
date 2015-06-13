using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float moveSpeed;
	public float flightSpeed;
	public float jumpSpeed;

	private Rigidbody rb;

	private float lastJump;
	private float jumpDelay;

	// Use this for initialization
	void Start () {
		jumpDelay = 0.5f;
		lastJump = Time.time - jumpDelay;
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		// Movement
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		Vector3 moveVec = new Vector3 (horizontal, 0, vertical) * moveSpeed;
		rb.AddForce (moveVec);

		// Jumping
		if (Input.GetButton ("Jump")) {
			if (OnGround () && (Time.time - lastJump >= jumpDelay)) {
				Vector3 jumpVec = new Vector3 (0, jumpSpeed, 0);
				rb.AddForce (jumpVec);
			}
		}
	}

	bool OnGround() {
		return Physics.Raycast(rb.position, -Vector3.up, 
		                       GetComponent<Collider>().bounds.extents.y + 0.1f);
	}

	void FixedUpdate() {

	}
}
