using UnityEngine;
using System.Collections;

public class testMovingAI : MonoBehaviour {
	//public float closeness = .01f;
	public float speed = 1.0f;
	public float moveLengthFromOrigin = 5.0f;
	Vector2 origin;
	//public float rotationOfPlatform = 0f;
	//Dictates if the platform is moving along y- or x-axis.
	public bool horizontal;
	//public bool alwaysMoving = true;
	//public buttonTrigger button;
	// Use this for initialization
	void Start () {
		origin = new Vector2 (transform.position.x, transform.position.y);
		//transform.Rotate (0f, 0f, rotationOfPlatform);
		if (horizontal) {
			transform.Rotate (0f, 0f, 90f);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
		Physics2D.IgnoreLayerCollision (12, 12);
		Physics2D.IgnoreLayerCollision (12, 9);
		Physics2D.IgnoreLayerCollision (12, 8);
			if (horizontal) 
			{
				if (this.transform.position.x > origin.x + moveLengthFromOrigin || this.transform.position.x < origin.x ) 
				{
					this.transform.Rotate (0f, 0f, 180f);
					//Added, because otherwise the wall would inconsistently get stuck at the edge of its range and just keep rotating without moving.
					transform.position += transform.up * 1.1f;
				}
			} 
			else  
			{
				if (this.transform.position.y > origin.y + moveLengthFromOrigin|| this.transform.position.y < origin.y ) 
				{
					this.transform.Rotate (0f, 0f, 180f);
					//See above
					transform.position += transform.up * 1.1f;
				}
	
			} 
			transform.position += transform.up * Time.deltaTime * speed;
	
		}


}

