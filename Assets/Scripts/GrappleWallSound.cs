using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GrappleWallSound : MonoBehaviour
{
	public AudioSource audioClip;

	void Start ()
	{
		audioClip = GetComponent<AudioSource> ();
	}

	public void playLandSound ()
	{
		audioClip.Play ();
	}
}
