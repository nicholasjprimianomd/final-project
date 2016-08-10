using UnityEngine;
using System.Collections;

public class BulletKillZombie : MonoBehaviour
{
	GameObject score;
	Timer gameScore;



	void Start ()
	{

		score = GameObject.FindWithTag ("Timer");
		gameScore = score.GetComponent<Timer> ();

	}



	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "Zombie") {
			gameScore.score = gameScore.score + 5;

			Destroy (coll.gameObject);
		}

	}
}
