using UnityEngine;
using System.Collections;

public class testMovingAI : MonoBehaviour {
	//public float closeness = .01f;
	public float speed = 1.0f;
	public float moveLengthFromOrigin = 5.0f;

	//private Transform Origin;
	//private float yOrigin;
	//private float xOrigin;
	// (... if you just want to remember where something starts, just store the vector directly:)
	Vector2 origin;

	public bool horizontal = true;
	public bool alwaysMoving = true;
	public GameObject button;
	// (1. this would be better practice:)
	// public ButtonTrigger button;
	// (2. then in the if() in Update:)
	// if ( ...... && button.isOn )
	
	// Use this for initialization
	void Start () {
		origin = new Vector2( transform.position.x, transform.position.y );
		
		// if horizontal, then rotate 90 degrees so it is on its side
		// do this in the beginning to make sure it's on its side
		if ( horizontal ) { 
			transform.Rotate(0f, 0f, 90f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (alwaysMoving|| (!alwaysMoving && button.GetComponent<buttonTrigger>().isOn)){ 
			
			if (horizontal) 
			{
				// the "this" is unnecessary
				// if (this.transform.position.x > origin.x + moveLengthFromOrigin || this.transform.position.x < origin.x - moveLengthFromOrigin) 
				if (transform.position.x > origin.x + moveLengthFromOrigin || transform.position.x < origin.x - moveLengthFromOrigin) 
				{
					this.transform.Rotate (0f, 0f, 180f);
			// you are already setting transform.position below
			//		transform.position += transform.up * 2;
				}
			} 
			// else if (!horizontal) {
			else { // the "else if(!horizontal)" is redundant, because else will accomplish the same thing
				// again, remember the "this" is redundant below
				if (this.transform.position.y > origin.y + moveLengthFromOrigin || this.transform.position.y < origin.y - moveLengthFromOrigin) 
				{
					this.transform.Rotate (0f, 0f, 180f);
				}
	
			} 
			transform.position += transform.up * Time.deltaTime * speed;
	
		}

	}
}

