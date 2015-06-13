using UnityEngine;
using System.Collections;

public class ThomasMovement : MonoBehaviour {
	public float moveSpeed = 10;
	public float flightSpeed = 10;
	public float jumpSpeed = 10;
	//public float rotateSpeed = 5;
	
	private Rigidbody rb;
	
	private float lastJump;
	private float jumpDelay;
	
	// Use this for initialization
	void Start () {
		jumpDelay = 0.5f;
		lastJump = Time.time - jumpDelay;
		rb = GetComponent<Rigidbody> ();
		
		//rb.freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update () {
		// Movement
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		Vector3 moveVec = new Vector3 (horizontal, 0, vertical) * moveSpeed;
		rb.AddForce (moveVec);
		
		// Rotation with mouse with right click
		//if (Input.GetMouseButton (1)) {
		//	float x = Input.GetAxis ("Mouse X");
		//	transform.Rotate (0, -x * rotateSpeed, 0);
		//}
		
		// Jumping
		if (Input.GetButton ("Jump")) {
			if (OnGround () && (Time.time - lastJump >= jumpDelay)) {
				Vector3 jumpVec = new Vector3 (0, jumpSpeed, 0);
				rb.AddForce (jumpVec);
			}
		}

		if(Input.GetKey (KeyCode.LeftShift)){
			Vector3 flyVec = new Vector3 (0, flightSpeed, 0);
			rb.AddForce (flyVec);
		}

	}
	
	bool OnGround() {
		return Physics.Raycast(rb.position, -Vector3.up, 
		                       GetComponent<Collider>().bounds.extents.y + 0.1f);
	}
	
	void FixedUpdate() {
		
	}
}
