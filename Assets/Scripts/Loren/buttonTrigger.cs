using UnityEngine;
using System.Collections;

public class buttonTrigger : MonoBehaviour {

	public float durationOn = 3f;
	public float elapsedTimes;
	public bool isOn = false;


	void OnTriggerEnter2D( Collider2D activator){
		if (activator.gameObject.tag == "Bullet") {
			this.GetComponent<SpriteRenderer> ().color = Color.black;
			isOn = true;

		}
	}

	public void ActivateButton(){
		elapsedTimes = 0f;
		while (durationOn > elapsedTimes) {
			this.gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			isOn = true;
			elapsedTimes += Time.deltaTime;
		}
		isOn = false;
		this.gameObject.GetComponent<SpriteRenderer> ().color = Color.black;
	}




}
