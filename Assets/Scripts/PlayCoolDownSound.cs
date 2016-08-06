using UnityEngine;
using System.Collections;

public class PlayCoolDownSound : MonoBehaviour
{
	AudioSource audio;
	// Use this for initialization
	void Start ()
	{
		audio = GetComponent <AudioSource> ();
	}


	public void playCoolDownSound ()
	{
		audio.Play ();
	}
}
