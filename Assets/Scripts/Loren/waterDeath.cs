using UnityEngine;
using System.Collections;
using System;
using UnityEditor;

public class waterDeath : MonoBehaviour
{
<<<<<<< HEAD
	private bool takingDamage;
	private float currentTime;
	private float startTime;
	public float coolDown = .25f;
	public int waterDamage = 3;

	void Update ()
	{
		
		currentTime = Time.time;


=======

	private bool takingDamage;
	private float currentTime;
	private float startTime;
	public float coolDown = .25f;
	public int waterDamage = 3;



	void Update ()
	{
		currentTime = Time.time;

>>>>>>> daece8cc9a4a78208f48f88e7501956c30755b53
	}

	void OnTriggerStay2D (Collider2D activator)
	{
		if (activator.GetComponent<PlayerGrapple> () != null && activator.gameObject.GetComponent<PlayerGrapple> ().isLerping == false) {
			takeDamage (activator);
		}
	}

	void OnTriggerEnter2D (Collider2D activator)
	{
		startTime = currentTime;
	}

<<<<<<< HEAD
	//void OnTriggerExit2D (Collider2D activator)
	//{
	//	startTime = currentTime;
	//}

=======
>>>>>>> daece8cc9a4a78208f48f88e7501956c30755b53
	void takeDamage (Collider2D activator)
	{
		if (currentTime - startTime > coolDown) {
			if (activator.GetComponent<PlayerTakeDamage> ().currentShield > waterDamage) {
				activator.GetComponent<PlayerTakeDamage> ().currentShield -= waterDamage * Mathf.CeilToInt (Time.deltaTime)/*Mathf.CeilToInt (Time.deltaTime / 100)*/;
<<<<<<< HEAD

				startTime = currentTime;
			} else {
				activator.GetComponent<PlayerTakeDamage> ().currentHealth -= waterDamage * Mathf.CeilToInt (Time.deltaTime) /*Mathf.CeilToInt (Time.deltaTime / 100)*/;

=======
				startTime = currentTime;

				if (!activator.GetComponent<AudioSource> ().isPlaying) {
					activator.GetComponent<AudioSource> ().Play ();
				}


			} else {
				activator.GetComponent<PlayerTakeDamage> ().currentHealth -= waterDamage * Mathf.CeilToInt (Time.deltaTime) /*Mathf.CeilToInt (Time.deltaTime / 100)*/;

				if (!activator.GetComponent<AudioSource> ().isPlaying) {
					activator.GetComponent<AudioSource> ().Play ();
				}


>>>>>>> daece8cc9a4a78208f48f88e7501956c30755b53
				startTime = currentTime;
			}
		}
	}
}
