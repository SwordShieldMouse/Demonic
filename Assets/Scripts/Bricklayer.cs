using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Bricklayer : MonoBehaviour {
	public Rigidbody Bricks;
	public Text DimensionText;
	private Vector3 offsetx;

	private float xlength;
	private float ylength;
	private float zlength;


	// Use this for initialization
	void Start () {
		//Renderer rend = GetComponent<Renderer> ();
		//xlength = Bricks.rend.bounds.size.x;
		xlength = 0;
		ylength = 0;
		zlength = 0;
		//ylength = Bricks.rend.bounds.size.y;
		//zlength = Bricks.rend.bounds.size.z;
		//DimensionText.text = "";
		//print(Bricks.transform.lossyScale);
	}
	
	// Update is called once per frame
	void Update () {
		//DimensionText.text = "X: " + xlength + "Y: " + ylength + "Z: " + zlength;
		//DimensionText.text = "Hello";
		//print(Bricks.transform.lossyScale);
	}
}
