using UnityEngine;
using System.Collections;

public class RCRealRoombaRaycast : MonoBehaviour
{

	public float coolDownMax = 4;
	public float minCoolDown = 1;
	private float currentTime;
	private float startTime;
	private bool isActive;
	private bool isTiming;


	void Start ()
	{
		isActive = true;
		isTiming = false;
	}

	void Update ()
	{

		float coolDown = Random.Range (minCoolDown, coolDownMax);

		currentTime = Time.time;

		if (currentTime - startTime > coolDown) {
			if (isActive) {
				isActive = false;
				isTiming = false;
			} else {
				isActive = true;
				isTiming = false;
			}
		}

		if (isActive) {
			for (int i = 0; i < this.transform.childCount; i++) {
				this.transform.GetChild (i).gameObject.SetActive (true);
			}
			if (!isTiming) {	
				isTiming = true;
				startTime = currentTime;
			}

		} else {
			for (int i = 0; i < this.transform.childCount; i++) {
				this.transform.GetChild (i).gameObject.SetActive (false);
			}
			if (!isTiming) {	
				isTiming = true;
				startTime = currentTime;
			}
		}


		// let's shoot a very short small raycast in front of us
		RaycastHit2D roombaHit = Physics2D.Raycast (transform.position, transform.up, 0.2f);
		// if the raycast hit something...
		if (roombaHit.collider != null) {
			// turn randomly 90 degrees left or right
			float randomNumber = Random.Range (0f, 1f);
			if (randomNumber > 0.5f) { // 50% chance to turn left
				transform.Rotate (0f, 0f, Random.Range (0f, 90f));
			} else {
				transform.Rotate (0f, 0f, Random.Range (-90f, 0f));
			}
		} else { // if the raycast hit NOTHING...
			// always go "forward" along it's local Up direction
			transform.position += transform.up * Time.deltaTime * 2f;
		}

	}
}