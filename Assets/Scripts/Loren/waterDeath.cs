using UnityEngine;
using System.Collections;

public class waterDeath : MonoBehaviour {


	void OnTriggerEnter2D( Collider2D activator){

		if (activator.GetComponent<PlayerGrapple> () != null && activator.gameObject.GetComponent<PlayerGrapple>().isLerping == false) {
			Destroy (activator.gameObject);
		}
	}

}
