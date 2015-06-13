using UnityEngine;
using System.Collections;

public class PlayerOffensiveAbilities : MonoBehaviour {
	public float fireCooldown = 1.0f;
	public float explodeCooldown = 1.0f;
	public float summonCooldown = 1.0f;

	public float explodePower = 20.0f;
	public float explodeRadius = 10.0f;

	private bool canFire;
	private bool canExplode;
	private bool canSummon;

	private float lastFire;
	private float lastExplode;
	private float lastSummon;


	// Use this for initialization
	void Start () {
		canFire = false;
		canExplode = true;
		canSummon = false;

		lastFire = Time.time;
		lastExplode = Time.time;
		lastSummon = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		Fire ();
		Explode ();
		SummonDemons ();
	}

	void Fire() {
	}

	void Explode() {
		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			if (canExplode && (Time.time - lastExplode >= explodeCooldown)) {
				Collider[] colliders = Physics.OverlapSphere (transform.position, explodeRadius);
				foreach (Collider c in colliders) {
					Rigidbody crb = c.GetComponent<Rigidbody> ();
					if (crb != null) {
						crb.AddExplosionForce (explodePower, transform.position, explodeRadius, 2.0f);
					}
				}
			}
		}
	}

	void SummonDemons() {
	}

}
