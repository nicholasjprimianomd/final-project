using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goto : MonoBehaviour
{

	public void loadStart ()
	{
		SceneManager.LoadScene ("Start");
	}

	public void loadInstruction ()
	{
		SceneManager.LoadScene ("Instructions");
	}

	public void loadCredits ()
	{
		SceneManager.LoadScene ("Credits");
	}
}


// merging screens into working game