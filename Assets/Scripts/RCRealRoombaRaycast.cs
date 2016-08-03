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


		RaycastHit2D roombahit = Physics2D.Raycast (transform.position, transform.up, 0.4f); //shoots raycast

		if (roombahit.collider != null && roombahit.collider.gameObject.tag != "Zombie") { //if raycast hits something 
			float randomNumber = Random.Range (0f, 1f); //turn randomly 90 degreees left or right
			if (randomNumber > 0.5f) {
				transform.Rotate (0f, 0f, 90f);
			} else {
				transform.Rotate (0f, 0f, -90f);
			}
		} else { //if raycast hits nothing, always go forward
			transform.position += transform.up * Time.deltaTime;
		}

	}
}