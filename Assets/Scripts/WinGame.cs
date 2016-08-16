using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement ;
using UnityEngine.UI;
public class WinGame : MonoBehaviour {
	public Text textString;
	public Transform PlayerCharacter;
	public Transform WinCondition ;
	public bool didWin = false;

	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ( (PlayerCharacter.position - WinCondition.position).magnitude < 4f) {

			textString.text = "Aha! The Treasure! \n(Press [SPACE] to take the treasure)";

			if ( Input.GetKey (KeyCode.Space) ) {
				didWin = true;
			}

		}
		if (didWin == true) {

			SceneManager.LoadScene (5);

		}
	}
}



