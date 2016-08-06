using UnityEngine;
using System.Collections;

public class testMovingAI : MonoBehaviour
{
	//public float closeness = .01f;
	public float speed = 1.0f;
	public float moveLengthFromOrigin = 5.0f;
	//	private Transform Origin;
	private float yOrigin;
	private float xOrigin;
	public bool horizontal = true;
	public bool alwaysMoving = true;
	public GameObject button;
	// Use this for initialization
	void Start ()
	{
		//	Origin = this.transform;
		yOrigin = this.transform.position.y;
		xOrigin = this.transform.position.x;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (alwaysMoving || (!alwaysMoving && button.GetComponent<buttonTrigger> ().isOn)) { 
			
			if (horizontal) {
				if (this.transform.position.x > xOrigin + moveLengthFromOrigin || this.transform.position.x < xOrigin - moveLengthFromOrigin) {
					this.transform.Rotate (0f, 0f, 180f);
					transform.position += transform.up * 2;
				}
			} else if (!horizontal) {
				if (this.transform.position.y > yOrigin + moveLengthFromOrigin || this.transform.position.y < yOrigin - moveLengthFromOrigin) {
					this.transform.Rotate (0f, 0f, 180f);
				}
	
			} 
			transform.position += transform.up * Time.deltaTime * speed;
	
		}

	}
}

