using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	public float durationOn = 3f;
	public float elapsedTimes;
	public bool isOn = false;




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
