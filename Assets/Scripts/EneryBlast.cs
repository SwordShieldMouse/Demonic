using UnityEngine;
using System.Collections;

public class EnergyBlast : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("RightShift")) {
			Vector3 jumpVec = new Vector3 (0, 5, 0);
			rb.AddForce (jumpVec);
			}
	
		}

	void FixedUpdate () {
	}
	
	}

