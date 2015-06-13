using UnityEngine;
using System.Collections;

public class prefabProjectileScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter(Collision collision){

			Destroy(this.gameObject);
		
	}

	// Update is called once per frame
	void Update () {
	
	}
}
