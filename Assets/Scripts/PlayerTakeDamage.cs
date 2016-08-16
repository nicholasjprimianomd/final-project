using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

//using UnityEditor;

public class PlayerTakeDamage : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth = 100;
	public float maxShield = 5;
	public float shieldRegenRate = 1;
	public float currentShield = 100;
	public AudioSource audioClip;

	void Start ()
	{
		audioClip = GetComponent<AudioSource> ();
	}

	void Update ()
	{
		if (currentHealth >= maxHealth) {
			currentHealth = maxHealth;
		}

		if (currentShield >= maxShield) {
			currentShield = maxShield;
		}
			

		if (currentHealth <= 0) {
			SceneManager.LoadScene ("Death Scene");
		}

		incShield ();
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "Zombie") {
			if (currentShield > 0) {
				if (!audioClip.isPlaying) {
					audioClip.Play ();
				}
				currentShield -= 1;
			} else {
				if (!audioClip.isPlaying) {
					audioClip.Play ();
				}
				currentHealth -= 1;
			}
		}
	}

	void incShield ()
	{
		currentShield += 1f * Time.deltaTime * shieldRegenRate;
	}
}
