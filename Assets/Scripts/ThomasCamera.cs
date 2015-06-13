using UnityEngine;
using UnityEngine;
using System.Collections;

public class ThomasCamera : MonoBehaviour {
	
	public GameObject player;
	
	private Vector3 offset;
	
	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () { //late means runs after all processes updated
		//each frame camera is moved along with player
		transform.position = player.transform.position + offset;
	}
}
