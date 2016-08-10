using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goto : MonoBehaviour {

	public Button buttonPrefab;


	void OnMouseDown() {
		Application.LoadLevel(4);
	}

//	void Start {
//
//		Button.onClick.AddListener ( 
//			delegate {
//				GoTo (); 
//			} 
//		);
//
//	}
//
//	public void GoTo() {
//		if (gameObject.name == "Instructions") {
//			Application.LoadLevel ("Instructions");
//		} else if (gameObject.name == "Credits") {
//			Application.LoadLevel ("Credits");
//		} else if (gameObject.name == "Start") {
//			Application.LoadLevel ("Start");
//		}
//	}

}
