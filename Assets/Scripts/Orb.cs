using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Networking;

public class Orb : MonoBehaviour
{

	public GameObject bullet;
	public Transform spawnPoint;
	public float xOffset = 0;
	public float yOffset = 1;
	public float bulletSpeed = 50;
	private float currentTime;
	private bool canShoot;
	private float coolDown;

	void Awake ()
	{
		canShoot = true;
	}

	void Update ()
	{
		currentTime = Time.time;

		if (currentTime - coolDown > 3) {
			canShoot = true;
		}

		if (Input.GetKeyDown (KeyCode.Q) && !canShoot) {
			if (!FindObjectOfType<PlayCoolDownSound> ().audio.isPlaying) {
				FindObjectOfType<PlayCoolDownSound> ().playCoolDownSound ();
			}
		}



		orb ();
	}

	void orb ()
	{
		if (Input.GetKeyDown (KeyCode.Q) && canShoot) {
			canShoot = false;
			coolDown = Time.time;
			Vector2 bulletDirection = (spawnPoint.position - transform.position).normalized;
			GameObject bulletPrefab = Instantiate (bullet, spawnPoint.position, transform.rotation) as GameObject;
			Rigidbody2D bulletRigidBody2D = bulletPrefab.GetComponent<Rigidbody2D> ();
			bulletRigidBody2D.AddForce (bulletDirection * bulletSpeed, ForceMode2D.Impulse);
		}
	}

}
