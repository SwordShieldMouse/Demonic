using UnityEngine;
using System.Collections;

public class Blast : MonoBehaviour {
	public Rigidbody energBlast;

	// Use this for initialization
	void Start () {
		//rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightShift)) {
			//GameObject.CreatePrimitive(PrimitiveType.Cube);	
			//Rigidbody clone;

			Rigidbody instantiatedProjectile = Instantiate(energyBlast,transform.position,transform.rotation)as Rigidbody;
			instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0,10));

			//for (int i = 0; i < 1; i++) {
			//	Instantiate(Cube, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
			//}








		}
	}
}
