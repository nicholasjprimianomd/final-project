using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;
using UnityEditor;

public class PlayerTakeDamage : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth = 100;
	public float maxShield = 5;
	public float shieldRegenRate = 1;
	public float currentShield = 100;

	void Update ()
	{
		Mathf.Clamp (currentShield, 0, maxShield);
		Mathf.Clamp (currentHealth, 0, maxHealth);

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
				currentShield -= 1;
			} else {
				currentHealth -= 1;
			}
		}
		if (coll.gameObject.tag == "Fire") {
			if (currentShield > 0) {
				currentShield -= 1;
			} else {
				currentHealth -= 1;
			}
		}


	}

	void incShield ()
	{
		currentShield += 1f * Time.deltaTime * shieldRegenRate;
	}
}
