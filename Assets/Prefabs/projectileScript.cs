using UnityEngine;
using System.Collections;

public class projectileScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	public float projectileSpeed = 5f;
	void Update () {
		transform.Translate(Vector3.right * bulletSpeed * Time.deltaTime);
	}
	
	void OnBecameInvisible () {
		this.gameObject.SetActive(false);
	}



	

}
