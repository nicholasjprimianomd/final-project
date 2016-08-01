using UnityEngine;
using System.Collections;

public class RCDeathTrigger : MonoBehaviour {


	void OnTriggerEnter2D( Collider2D activator ) {
		if ( activator.gameObject.tag == "Player") {
			Destroy( activator.gameObject );

		}
	}

	void OnTriggerStay2D( Collider2D activator ) {
			if ( activator.gameObject.tag == "Player") {
				Destroy( activator.gameObject );
		} 
}
}
