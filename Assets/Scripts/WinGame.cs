using UnityEngine;
using System.Collections;

public class WinGame : MonoBehaviour {
	public Transform PlayerCharacter;
	public Transform WinCondition ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( (PlayerCharacter.position - WinCondition.position).magnitude < .5f) {

			Debug.Log( "Aha! The Treasure! \n(Press [SPACE] to take the treasure)");

			if ( Input.GetKey (KeyCode.Space) ) {
				//didPlayerWin = true;
			}

		}
	}
}
