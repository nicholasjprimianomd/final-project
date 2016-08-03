using UnityEngine;
using System.Collections;

public class RCDeathTrigger : MonoBehaviour
{


	void OnCollisionEnter2D (Collision2D activator)
	{
		if (activator.gameObject.tag == "Player") {
			Destroy (activator.gameObject);

		}
	}

	void OnCollisionStay2D (Collision2D activator)
	{
		if (activator.gameObject.tag == "Player") {
			Destroy (activator.gameObject);
		} 
	}
}
