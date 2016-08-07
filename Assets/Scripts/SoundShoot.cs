using UnityEngine;
using System.Collections;

public class SoundShoot : MonoBehaviour { //grapple sound
	public AudioSource myAudio; //makes available in inspector
	//can deckare mulitple audio sources

	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown (KeyCode.E) ) {
//			myAudio.Play();
			// ^ sound overlay
			// \/shot cannot be interrupted
			myAudio.PlayOneShot ( myAudio.clip ); //use for footsteps
		}
	}
}
