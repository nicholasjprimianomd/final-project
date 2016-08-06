using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showHumanPlayerName : MonoBehaviour
{

	// Use this for initialization
	void Update ()
	{
		GetComponent<Text> ().text = PlayerPrefs.GetString ("Human Player");
	}
	

}
