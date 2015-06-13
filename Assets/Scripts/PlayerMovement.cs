using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float moveSpeed = 10;
	public float flightSpeed = 10;
	public float jumpSpeed = 10;
	public float rotateSpeed = 5;
	public float jumpDelay = 0.5f;

	private Rigidbody rb;

	private bool isFlying;
	private float lastJump;


	// Use this for initialization
	void Start () {
		isFlying = false;
		lastJump = Time.time - jumpDelay;
		rb = GetComponent<Rigidbody> ();

		rb.freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update () {
		// Movement
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		Vector3 moveVec = new Vector3 (horizontal, 0, vertical) * moveSpeed;
		rb.AddForce (moveVec);

		// Flight
		CheckFlight ();
		if (isFlying) {
			rb.useGravity = false;
			DoFlight();
		}

		// Jumping
		CheckJump ();
	}

	void CheckJump() {
		if (Input.GetButtonDown ("Jump") && !isFlying) {
			if (OnGround () && (Time.time - lastJump >= jumpDelay)) {
				Vector3 jumpVec = new Vector3 (0, jumpSpeed, 0);
				rb.AddForce (jumpVec);
				lastJump = Time.time;
			}
		}
	}

	void DoFlight() {
		if (Input.GetButton ("Descend")) {
			Vector3 descend = new Vector3(0, -flightSpeed, 0);
			rb.AddForce(descend);
		}
		if (Input.GetButton ("Jump")) {
			Vector3 ascend = new Vector3(0, flightSpeed, 0);
			rb.AddForce(ascend);
		}
	}

	void CheckFlight() {
		if (Input.GetButton("Flight")) {
			isFlying = !isFlying;
			rb.useGravity = !rb.useGravity;
		}
	}

	bool OnGround() {
		return Physics.Raycast(rb.position, -Vector3.up, 
		                       GetComponent<Collider>().bounds.extents.y + 0.1f);
	}

	void FixedUpdate() {

	}
}
