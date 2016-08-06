using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showPlantPlayerName : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		GetComponent<Text> ().text = PlayerPrefs.GetString ("Plant Player");
	}

}
