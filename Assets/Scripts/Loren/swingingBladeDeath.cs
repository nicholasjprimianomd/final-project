using UnityEngine;
using System.Collections;

public class swingingBladeDeath : MonoBehaviour
{

	void OnTriggerEnter2D (Collider2D activator)
	{

		if (activator.gameObject.tag == "Player") {
			Destroy (activator.gameObject);
		}

		print ("Hit");
	}
}
