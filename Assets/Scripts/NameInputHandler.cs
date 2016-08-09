using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text;


public class NameInputHandler : MonoBehaviour
{

	public InputField humanPlayerInput;
	public InputField plantPlayerInput;
	public Image startButton;
	public Text startButtonText;
	private string humanPlayerName;
	private string plantPlayerName;

	void Start ()
	{
		startButton.enabled = false;
		startButtonText.enabled = false;
	}

	void Update ()
	{
		if (humanPlayerName != null && plantPlayerName != null) {
			startButton.enabled = true;
			startButtonText.enabled = true;
		}

	}

	public void getHumanPlayerName ()
	{
		humanPlayerName = humanPlayerInput.text;
		PlayerPrefs.SetString ("Human Player", humanPlayerName);
	}

	public void getPlantPlayerName ()
	{
		plantPlayerName = plantPlayerInput.text;
		PlayerPrefs.SetString ("Plant Player", plantPlayerName);
	}

}
