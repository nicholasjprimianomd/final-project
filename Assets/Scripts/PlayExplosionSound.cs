using UnityEngine;
using System.Collections;

public class PlayExplosionSound : MonoBehaviour
{
	public bool isExploding;


	void Start ()
	{
		isExploding = false;
	}

	void Update ()
	{
		if (isExploding) {
			Debug.Log ("Exploding");
			AudioSource audio = GetComponent<AudioSource> ();
			audio.PlayOneShot (GetComponent<AudioSource> ().clip);
			isExploding = false;
		}

	}
}
