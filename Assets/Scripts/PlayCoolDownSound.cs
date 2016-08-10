using UnityEngine;
using System.Collections;

public class PlayCoolDownSound : MonoBehaviour
{
	public AudioSource audioClip;
	// Use this for initialization
	void Start ()
	{
		audioClip = GetComponent <AudioSource> ();
	}


	public void playCoolDownSound ()
	{
		audioClip.Play ();
	}
}
