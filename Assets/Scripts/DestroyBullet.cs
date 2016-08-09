using UnityEngine;
using System.Collections;

public class DestroyBullet : MonoBehaviour
{
	SpriteRenderer spr;
	TrailRenderer trail;

	void Start ()
	{
		spr = GetComponent<SpriteRenderer> ();
		trail = GetComponentInChildren<TrailRenderer> ();
	}

	void Update ()
	{
		if (GetComponent<Rigidbody2D> ().velocity.magnitude < 1f) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		spr.enabled = false;
		trail.enabled = false;
	}
}
