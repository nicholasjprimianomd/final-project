using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class RCDeathTrigger : MonoBehaviour
{


	void OnCollisionEnter2D (Collision2D activator)
	{
		if (activator.gameObject.tag == "Player") {
			SceneManager.LoadScene ("Death Scene");

		}
	}

	void OnCollisionStay2D (Collision2D activator)
	{
		if (activator.gameObject.tag == "Player") {
			SceneManager.LoadScene ("Death Scene");
		} 
	}
}
