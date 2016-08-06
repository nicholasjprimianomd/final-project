using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{

	private GameObject timer;
	//public bool didRestart = false;

	void Start ()
	{
		//Delete Player Prefs
		PlayerPrefs.DeleteKey ("Human Player");
		PlayerPrefs.DeleteKey ("Plant Player");
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene ("Game");
			//restart game timer
			timer = GameObject.FindGameObjectWithTag ("Timer");
			Timer endTime = timer.GetComponent<Timer> ();
			endTime.timer = 0f;
			//didRestart = true;
			Destroy (timer);
		}

	}
}
