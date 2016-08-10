using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
	// Update is called once per frame
	private GameObject timer;
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			timer = GameObject.FindGameObjectWithTag ("Timer");
			Timer endTime = timer.GetComponent<Timer> ();
			endTime.timer = 0f;
			//didRestart = true;
			Destroy (timer);
		}	
	}
}
