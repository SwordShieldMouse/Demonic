using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float moveSpeed = 10;
	public float flightSpeed = 10;
	public float jumpSpeed = 10;

	private Rigidbody rb;
	private bool hasJumped;

	// Use this for initialization
	void Start () {
		hasJumped = false;
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		// Movement
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		Vector3 moveVector = new Vector3 (horizontal, 0, vertical) * moveSpeed;
		rb.AddForce (moveVector);

		// Jumping

	}

	void FixedUpdate() {

	}
}
