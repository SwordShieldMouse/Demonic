using UnityEngine;
using System.Collections;
using System.Collections.Generic; // Remember to add this line, otherwise the List won't work

public class ShootScript : MonoBehaviour {
	
	public float bulletSpeed = 5f;
	public GameObject bullet; // Drag and drop your x axis bullet here
	List<GameObject> bulletList; // This is a List of bullets, you can just think it as an array at this point
	// For more information of List, check the tut here:
	// http://unity3d.com/learn/tutorials/modules/intermediate/scripting/lists-and-dictionaries
	// It's short (5 mins) and informative
	public int maxBulletOnX = 8; // The limit of bullet on x axis 
	// You can always adjust the limit in inspector without going into the code
	
	void Start () {
		bulletList = new List<GameObject>();
		for (int i = 0; i < maxBulletOnX; i++)
		{
			bulletList.Add(Instantiate(bullet,Vector3.zero,Quaternion.identity));
			// What this line does is to "instantiate" the prefab (aka. your bullet you want to shoot)
			// Instantiate is good for cloning duplicated object like bullet
			// For more information of Instantiate, check here:
			// http://docs.unity3d.com/Documentation/Manual/InstantiatingPrefabs.html
			// It's usually bad to instantiate/destroy at runtime, but you don't have to worry about it at this point
			bulletList[i].GetComponent<BulletScript>().bulletSpeed = bulletSpeed;
			// This line will access your bullet's script and set the speed for it.
			// For more information of accessing another script, check here:
			// http://unitygems.com/script-interaction1/
			bulletList[i].SetActive(false);
			// This will de-activate your bullet when started up
		}
	}
	
	void Shoot () {
		GameObject temp = bulletList.Find(go => go.activeInHierarchy == false});
		// This is called lambda expression. You don't have to know what this is now.
		// What it does is to find bullet that is waiting to be used.
		if (temp != null)
		{
			temp.transform.position = transform.position + offset;
			// You might want modify the position value by yourself
			// What this does is to set the bullet at right place, aka where you shoot
			// Now it shoots from the center of your character
			temp.SetActive(true);
		}
	}
	
	void Update () {
		if (Input.GetMouseButtonDown(0)) // 0 means left click
		{
			Shoot();
		}
	}
}