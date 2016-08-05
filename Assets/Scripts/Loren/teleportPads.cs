using UnityEngine;
using System.Collections;

public class teleportPads : MonoBehaviour {
	public GameObject partner;
	public float xcoordsLanding = 1f;
	public float ycoordsLanding = 1f;


	void Start(){
		//Transform newLocation = partner.transform;
	}

	void Update(){
		
	}

	void OnTriggerEnter2D( Collider2D activator){
		if (activator.GetComponent<teleportable> () != null) {
			activator.transform.position = partner.transform.position+ new Vector3(xcoordsLanding,ycoordsLanding,0f);
		}

	}
}
