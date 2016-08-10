using UnityEngine;
using System.Collections;

public class RCRealRoombaRaycast : MonoBehaviour
{

	public float coolDownMax = 4;
	public float minCoolDown = 1;
	public float speed = 1f;
	private float currentTime;
	private float startTime;
	private bool isActive;
	private bool isTiming;
	public Vector3 currentDirection ;


	void Start ()
	{

		isActive = true;
		isTiming = false;
		currentDirection = transform.up;
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


		RaycastHit2D roombahit = Physics2D.Raycast (transform.position, currentDirection, 2f); //shoots raycast


		if (roombahit.collider != null && roombahit.collider.gameObject.tag != "Zombie") { //if raycast hits something 
			int randomNumber = Random.Range (0, 4); //turn randomly 90 degreees left or right; since we're using objects (the spheres) 
			//that have children lasers attached to them we can't use transform.rotate to make this function work, 
			//thus we must change the "currentDirection" according to the transform.up and transform.right axes
			if (randomNumber == 0) {
				currentDirection = transform.right ;
			} if (randomNumber == 1) {
				currentDirection = -transform.right;
			}  if (randomNumber == 2) {
				currentDirection = transform.up;
			}  if (randomNumber == 3) {
				currentDirection = -transform.up;
			} //since we've only got four options it's best to use the integer generator in Random.Range instead of the float generator 
			//(that could generate tons of options from a range of 0f to 1f)
		} else { //if raycast hits nothing, always go in the current direction it was headed in
			transform.position += currentDirection * Time.deltaTime * speed;
		}

	}
}